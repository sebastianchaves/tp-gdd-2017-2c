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

namespace PagoAgilFrba.AbmFactura
{
    public partial class ModificacionFactura : Form
    {

        private Factura facturaACargar;
        private Factura facturaModificada;
        private FacturaDAO<Factura> facturaDao;

        private Cliente clienteEncontrado;
        private ClienteDAO<Cliente> clienteDao;
        private Empresa empresaEncontrada;
        private EmpresaDAO<Empresa> empresaDao;

        private ConceptoDAO<Concepto> conceptoDao;
        private List<Concepto> conceptosACargar;
        private List<Concepto> conceptosModificados;

        private Concepto nuevoConcepto;

        public ModificacionFactura()
        {
            InitializeComponent();

            Utils.iniciarGrids(this.itemsGrid);

            this.facturaDao = new FacturaDAO<Factura>();
            this.facturaModificada = new Factura();
            this.clienteDao = new ClienteDAO<Cliente>();
            this.empresaDao = new EmpresaDAO<Empresa>();

            this.conceptoDao = new ConceptoDAO<Concepto>();
            this.conceptosACargar = new List<Concepto>();
            this.conceptosModificados = new List<Concepto>();

            this.nuevoConcepto = new Concepto();

            this.iniciarConceptosGrid();
        }

        private void iniciarConceptosGrid()
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");

            itemsGrid.DataSource = resultadosConceptos;
        }

        private void actualizarFactura()
        {
            if (camposCompletos())
            {
                if (!this.facturaACargar.pagada && this.facturaACargar.idRendicion == 0)
                {
                    this.calcularTotal();
                    this.facturaDao.updateFactura(this.facturaModificada);
                    this.agregarConceptos();
                    MessageBox.Show("Datos actualizados!");
                }
                else
                {
                    MessageBox.Show("La factura se encuentra pagada o ya fue rendida.");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
        }

        private Boolean camposCompletos()
        {
            return this.numeroInput.Text != "" &&
                this.fechaAltaInput.Value.ToString() != "" &&
                this.fechaVencimientoInput.Value.ToString() != "";
        }

        private void agregarConceptos()
        {
            int idNuevaFactura = this.facturaDao.obtenerFacturas(this.facturaModificada.numero).ElementAt(0).id;

            foreach (Concepto concepto in this.conceptosModificados)
            {
                if (concepto.idFactura == 0)
                {
                    concepto.idFactura = idNuevaFactura;
                    this.conceptoDao.agregarConcepto(concepto);
                }
                else
                {
                    this.conceptoDao.updateConcepto(concepto);
                }
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            foreach (Concepto concepto in this.conceptosModificados)
            {
                total += (concepto.cantidad * concepto.monto);
            }

            this.facturaModificada.total = total;
        }

        private void cargarDatos()
        {
            this.facturaModificada.id = this.facturaACargar.id;
            this.facturaModificada.numero = this.facturaACargar.numero;
            this.facturaModificada.fechaAlta = this.facturaACargar.fechaAlta;
            this.facturaModificada.total = this.facturaACargar.total;
            this.facturaModificada.fechaVencimiento = this.facturaACargar.fechaVencimiento;
            this.facturaModificada.idCliente = this.facturaACargar.idCliente;
            this.facturaModificada.idEmpresa = this.facturaACargar.idEmpresa;
            this.facturaModificada.idRendicion = this.facturaACargar.idRendicion;
            this.facturaModificada.pagada = this.facturaACargar.pagada;

            this.clienteInput.Text = this.clienteDao.findClienteById(this.facturaACargar.idCliente.ToString()).nombre;
            this.empresaInput.Text = this.empresaDao.findEmpresaById(this.facturaACargar.idEmpresa.ToString()).nombre;
            this.numeroInput.Text = this.facturaACargar.numero.ToString();
            this.fechaAltaInput.Value = this.facturaACargar.fechaAlta;
            this.fechaVencimientoInput.Value = this.facturaACargar.fechaVencimiento;

            this.conceptosACargar = this.conceptoDao.findConceptos(this.facturaACargar.id.ToString());

            this.cargarConceptos();
        }

        private void cargarConceptos()
        {
            this.conceptosModificados.AddRange(this.conceptosACargar);
            this.agregarTodosAGrid(this.conceptosModificados);
        }

        private void agregarAGrid()
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");

            foreach (Concepto concepto in this.conceptosModificados)
            {
                resultadosConceptos.Rows.Add(concepto.monto, concepto.cantidad);
            }

            itemsGrid.DataSource = resultadosConceptos;
        }

        private void agregarTodosAGrid(List<Concepto> conceptos)
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");

            foreach (Concepto concepto in conceptos)
            {
                resultadosConceptos.Rows.Add(concepto.monto, concepto.cantidad);
            }

            itemsGrid.DataSource = resultadosConceptos;
        }

        private void agregarAGrid(Concepto concepto)
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");

            resultadosConceptos.Rows.Add(concepto.monto, concepto.cantidad);

            this.itemsGrid.DataSource = resultadosConceptos;
        }

        private void habilitarCampos()
        {
            this.botonBuscarCliente.Enabled = true;
            this.botonBuscarEmpresa.Enabled = true;

            this.fechaAltaInput.Enabled = true;
            this.fechaVencimientoInput.Enabled = true;

            this.montoInput.Enabled = true;
            this.cantidadInput.Enabled = true;
            this.botonAgregarConcepto.Enabled = true;
            this.botonEliminarConcepto.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.botonBuscarCliente.Enabled = false;
            this.botonBuscarEmpresa.Enabled = false;

            this.fechaAltaInput.Enabled = false;
            this.fechaVencimientoInput.Enabled = false;

            this.montoInput.Enabled = false;
            this.cantidadInput.Enabled = false;
            this.botonAgregarConcepto.Enabled = false;
            this.botonEliminarConcepto.Enabled = false;
        }

        private void agregarConcepto()
        {
            if (this.camposConceptoCompletos())
            {
                this.conceptosModificados.Add(nuevoConcepto);
                this.agregarAGrid();
            }
            else
            {
                MessageBox.Show("Complete los datos faltantes del concepto...");
            }
        }

        private Boolean camposConceptoCompletos()
        {
            return this.cantidadInput.Text != "" && this.montoInput.Text != "";
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaFactura busquedaForm = new BusquedaFactura())
            {
                busquedaForm.ShowDialog(this);
                this.facturaACargar = busquedaForm.getFacturaEncontrada();

                if (this.facturaACargar != null)
                {
                    this.botonActualizar.Enabled = true;
                    this.cargarDatos();
                    this.habilitarCampos();
                }
            }
        }

        // Boton Actualizar
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            this.actualizarFactura();
            Utils.clearTextBoxes(this);
            this.nuevoConcepto = new Concepto();
            this.facturaACargar = new Factura();
            this.facturaModificada = new Factura();
            this.clienteEncontrado = new Cliente();
            this.empresaEncontrada = new Empresa();
            this.conceptosACargar = new List<Concepto>();
            this.conceptosModificados = new List<Concepto>();
            this.deshabilitarCampos();
            this.botonActualizar.Enabled = false;
        }

        // Boton Buscar Cliente
        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaForm = new BusquedaCliente())
            {
                busquedaForm.ShowDialog(this);
                this.clienteEncontrado = busquedaForm.getClienteEncontrado();
                this.clienteInput.Text = this.clienteEncontrado.nombre;
                this.facturaModificada.idCliente = this.clienteEncontrado.id;
            }
        }

        // Boton Buscar Empresa
        private void botonBuscarEmpresa_Click(object sender, EventArgs e)
        {
            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa())
            {
                busquedaForm.ShowDialog(this);
                this.empresaEncontrada = busquedaForm.getEmpresaEncontrada();
                this.empresaInput.Text = this.empresaEncontrada.nombre;
                this.facturaModificada.idEmpresa = this.empresaEncontrada.id;
            }
        }

        private void botonAgregarConcepto_Click(object sender, EventArgs e)
        {
            this.agregarConcepto();
            this.cantidadInput.Clear();
            this.montoInput.Clear();
            this.nuevoConcepto = new Concepto();
        }

        private void botonEliminarConcepto_Click(object sender, EventArgs e)
        {
            if (itemsGrid.Rows.Count > 0)
            {
                int index = this.itemsGrid.SelectedCells[0].RowIndex;
                
                decimal conceptoMonto = Decimal.Parse(this.itemsGrid.Rows[index].Cells[0].Value.ToString());
                int conceptoCantidad = Int32.Parse(this.itemsGrid.Rows[index].Cells[1].Value.ToString());

                this.itemsGrid.Rows.RemoveAt(index);

                Concepto conceptoAEliminar = this.conceptosACargar.Find(concepto => concepto.cantidad == conceptoCantidad && concepto.monto == conceptoMonto);

                if (conceptoAEliminar != null)
                {
                    this.conceptoDao.deleteConcepto(conceptoAEliminar);
                    this.conceptosModificados.Remove(conceptoAEliminar);
                }
                else
                {
                    this.conceptosModificados.Remove(
                        this.conceptosModificados.Find(concepto => 
                        concepto.cantidad == conceptoCantidad 
                        && concepto.monto == conceptoMonto));
                }

                this.agregarTodosAGrid(this.conceptosModificados);
            }
            else
            {
                MessageBox.Show("No hay conceptos para eliminar");
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga Monto
        private void montoInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.nuevoConcepto.monto = Int32.Parse(this.montoInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, montoTooltip, montoInput);
            }
        }

        // Carga Cantidad
        private void cantidadInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.nuevoConcepto.cantidad = Int32.Parse(this.cantidadInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, cantidadTooltip, cantidadInput);
            }
        }

        // Carga Fecha Alta
        private void fechaAltaInput_Leave(object sender, EventArgs e)
        {
            this.facturaModificada.fechaAlta = this.fechaAltaInput.Value;
        }

        // Carga Fecha Vencimiento
        private void fechaVencimientoInput_Leave(object sender, EventArgs e)
        {
            this.facturaModificada.fechaVencimiento = this.fechaVencimientoInput.Value;
        }

    }
}
