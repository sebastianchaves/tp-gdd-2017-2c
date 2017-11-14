using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPagoForm : Form
    {

        private Pago nuevoPago;
        private PagoDAO<Pago> pagoDao;
        private DataTable tablaFacturas;

        private List<Factura> facturasAPagar;

        private ClienteDAO<Cliente> clienteDao;
        private EmpresaDAO<Empresa> empresaDao;

        private FormaPagoDAO<FormaPago> formaPagoDao;
        private List<FormaPago> formasPagoDisponibles;

        private PagoFacturaDAO<PagoFactura> pagoFacturaDao;

        private FacturaDAO<Factura> facturaDao;

        public RegistroPagoForm()
        {
            InitializeComponent();

            this.pagoFacturaDao = new PagoFacturaDAO<PagoFactura>();

            this.clienteDao = new ClienteDAO<Cliente>();
            this.empresaDao = new EmpresaDAO<Empresa>();

            this.formaPagoDao = new FormaPagoDAO<FormaPago>();
            this.formasPagoDisponibles = new List<FormaPago>();
            this.cargarFormasDePago();

            this.facturaDao = new FacturaDAO<Factura>();

            this.facturasAPagar = new List<Factura>();
            this.pagoDao = new PagoDAO<Pago>();
            this.nuevoPago = new Pago();
            this.iniciarFacturasGrid();
        }

        private void registrarPago()
        {
            if (this.hayFacturas())
            {
                if (this.seSeleccionoCliente())
                {
                    this.cargarValoresPago();
                    int idNuevoPago = this.pagoDao.insertPago(this.nuevoPago);
                    this.cargarPagoFacturas(idNuevoPago);
                    this.facturasGrid.Refresh();
                    this.facturasGrid.DataSource = null;
                    
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para registrar el pago");
                }
            }
            else
            {
                MessageBox.Show("Debe cargar por lo menos 1 factura para registrar el pago");
            }
        }

        private void cargarPagoFacturas(int idNuevoPago)
        {
            foreach (Factura factura in this.facturasAPagar)
            {
                PagoFactura pagoFactura = new PagoFactura();
                pagoFactura.idFactura = this.facturaDao.findFacturaByNumero(factura.numero).id;
                pagoFactura.idPago = idNuevoPago;

                this.pagoFacturaDao.agregarPagoFactura(pagoFactura);
            }
        }

        private void cargarValoresPago()
        {
            this.nuevoPago.fechaCobro = Utils.appDate;
            this.nuevoPago.importe = this.calcularImporteTotal();
            this.nuevoPago.idFormaPago = this.obtenerFormaPagoElegida();
            this.nuevoPago.idSucursal = Utils.usuarioGlobal.idSucursal;
        }

        private int obtenerFormaPagoElegida()
        {
            int selectedComboIndex = this.formasPagoCombo.SelectedIndex;
            return this.formasPagoDisponibles.Find(forma => forma.indexCombo.Equals(selectedComboIndex)).id;
        }

        private Decimal calcularImporteTotal()
        {
            decimal importeTotal = 0;

            foreach (Factura factura in this.facturasAPagar)
            {
                importeTotal += factura.total;
            }

            return importeTotal;
        }

        private Boolean seSeleccionoCliente()
        {
            return this.nuevoPago.idCliente != 0;
        }

        private Boolean hayFacturas()
        {
            return this.facturasAPagar.Count > 0;
        }

        private void cargarFormasDePago()
        {
            this.formasPagoDisponibles = this.formaPagoDao.findFormasPago();

            var dataSource = new List<String>();

            for (int i = 0; i < this.formasPagoDisponibles.Count; i++)
            {
                this.formasPagoDisponibles.ElementAt(i).indexCombo = i;
                dataSource.Add(this.formasPagoDisponibles.ElementAt(i).nombre);
            }

            formasPagoCombo.DataSource = dataSource;
        }

        private void iniciarFacturasGrid()
        {
            Utils.iniciarGrids(facturasGrid);
            this.tablaFacturas = new DataTable();
            this.tablaFacturas.Columns.Add("Numero");
            this.tablaFacturas.Columns["Numero"].ReadOnly = true;

            this.tablaFacturas.Columns.Add("Total");
            this.tablaFacturas.Columns["Total"].ReadOnly = true;

            this.tablaFacturas.Columns.Add("Fecha de Vencimiento");
            this.tablaFacturas.Columns["Fecha de Vencimiento"].ReadOnly = true;

            this.tablaFacturas.Columns.Add("Cliente");
            this.tablaFacturas.Columns["Cliente"].ReadOnly = true;

            this.tablaFacturas.Columns.Add("Empresa");
            this.tablaFacturas.Columns["Empresa"].ReadOnly = true;
        }

        private void cargarNuevaFactura(Factura nuevaFactura)
        {
            this.tablaFacturas.Rows.Add(nuevaFactura.numero,
                    nuevaFactura.total, 
                    nuevaFactura.fechaVencimiento,
                    this.clienteDao.findClienteById(nuevaFactura.idCliente.ToString()).nombre,
                    this.empresaDao.findEmpresaById(nuevaFactura.idEmpresa.ToString()).nombre);

            this.facturasGrid.DataSource = tablaFacturas;
        }

        // Eventos
        // Boton Cargar Factura
        private void botonCargarFactura_Click(object sender, EventArgs e)
        {
            using (CargaFactura cargaForm = new CargaFactura())
            {
                cargaForm.ShowDialog(this);

                Factura nuevaFactura = cargaForm.getNuevaFactura();

                if (nuevaFactura.numero != 0)
                {
                    this.cargarNuevaFactura(nuevaFactura);
                    this.facturasAPagar.Add(nuevaFactura);
                }
                else 
                {
                    MessageBox.Show("No se cargo ninguna factura, intente nuevamente.");
                }
                
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton Registrar
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            this.registrarPago();
            this.nuevoPago = new Pago();
            this.facturasAPagar = new List<Factura>();
        }

        // Boton Eliminar
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (facturasGrid.SelectedRows.Count > 0)
            {
                int index = facturasGrid.SelectedRows[0].Index;

                int numeroFacturaAEliminar = Int32.Parse(this.facturasGrid.Rows[index].Cells[0].Value.ToString());

                this.facturasAPagar.Remove(
                    this.facturasAPagar.Find(
                    factura => factura.numero == numeroFacturaAEliminar));

                facturasGrid.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("No selecciono ninguna factura para ser eliminar");
            }
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaClienteForm = new BusquedaCliente())
            {
                busquedaClienteForm.ShowDialog(this);
                
                Cliente clienteEncontrado = busquedaClienteForm.getClienteEncontrado();

                if (clienteEncontrado.habilitado)
                {
                    this.nuevoPago.idCliente = clienteEncontrado.id;
                    this.clienteInput.Text = clienteEncontrado.nombre;
                }
                else if (clienteEncontrado.id == 0)
                {
                    MessageBox.Show("No se selecciono ningun cliente.");
                }
                else
                {
                    MessageBox.Show("Ese cliente se encuentra deshabilitado.");
                }
            }
        }
    
    }
}
