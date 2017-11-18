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
    public partial class CargaFactura : Form
    {

        private Factura nuevaFactura;
        private SucursalDAO<Sucursal> sucursalDao;
        private FacturaDAO<Factura> facturaDao;
        private EmpresaDAO<Empresa> empresaDao;

        public CargaFactura()
        {
            InitializeComponent();
            this.nuevaFactura = new Factura();
            this.sucursalDao = new SucursalDAO<Sucursal>();
            empresaDao = new EmpresaDAO<Empresa>();
            this.facturaDao = new FacturaDAO<Factura>();
            this.cargarFechasDefault();
        }

        private void cargarFechasDefault()
        {
            this.fechaCobroInput.CustomFormat = "";
            this.fechaVencimientoInput.CustomFormat = "";

            this.fechaCobroInput.Value = DateTime.Now;

            this.fechaVencimientoInput.Value = DateTime.Today;
            this.nuevaFactura.fechaVencimiento = this.fechaVencimientoInput.Value;
        }


        public Factura getNuevaFactura()
        {
            return this.nuevaFactura;
        }

        private Boolean camposCompletos()
        {
            return !this.numeroInput.Text.Equals("") &&
                !this.importeInput.Text.Equals("")
                && !this.fechaVencimientoInput.Text.Equals("");
        }

        // Eventos
        // Boton Buscar Cliente
        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaClienteForm = new BusquedaCliente())
            {
                busquedaClienteForm.ShowDialog(this);
                Cliente clienteEncontrado = busquedaClienteForm.getClienteEncontrado();

                if (clienteEncontrado != null)
                {
                    this.nuevaFactura.idCliente = clienteEncontrado.id;
                    this.clienteInput.Text = clienteEncontrado.nombre;
                }
                else
                {
                    MessageBox.Show("No se ingreso ningun cliente.");
                }
            }
        }

        // Boton Buscar Empresa
        private void botonBuscarEmpresa_Click(object sender, EventArgs e)
        {
            using (BusquedaEmpresa busquedaEmpresaForm = new BusquedaEmpresa())
            {
                busquedaEmpresaForm.ShowDialog(this);
                Empresa empresaEncontrada = busquedaEmpresaForm.getEmpresaEncontrada();

                if (empresaEncontrada != null)
                {
                    if (empresaEncontrada.activo)
                    {
                        this.nuevaFactura.idEmpresa = empresaEncontrada.id;
                        this.empresaInput.Text = empresaEncontrada.nombre;
                    }
                    else
                    {
                        MessageBox.Show("La empresa ingresada no esta activa.");
                    }
                }
                else
                {
                    MessageBox.Show("No se ingreso ninguna empresa.");
                }

            }
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.camposCompletos())
            {
                if (!this.nuevaFactura.pagada)
                {
                    List<Factura> list = facturaDao.obtenerFacturas(nuevaFactura.numero);
                    if (list.Count > 0)
                    {
                        if (empresaDao.findEmpresaById(list.ElementAt(0).idEmpresa.ToString()).activo)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("La empresa responsable de la factura no se encuentra habilitada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La factura ingresada no existe en el sistema.");
                    }
                }
                else
                {
                    MessageBox.Show("La factura ingresada se encuentra pagada.");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Cargando Datos
        // Numero
        private void numeroInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.nuevaFactura.numero = Int32.Parse(this.numeroInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, numeroTooltip, numeroInput);
            }
        }

        // Importe
        private void importeInput_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal total = Decimal.Parse(this.importeInput.Text);
                if (total >= 0)
                {
                    this.nuevaFactura.total = total;
                }
                else
                {
                    MessageBox.Show("El importe debe ser mayor o igual a 0");
                    this.importeInput.Clear();
                }
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, importeTooltip, importeInput);
            }
        }

        // Fecha Vencimiento
        private void fechaVencimientoInput_Leave(object sender, EventArgs e)
        {
            if (Utils.fechaValida(this.fechaVencimientoInput.Value))
            {
                this.nuevaFactura.fechaVencimiento = this.fechaVencimientoInput.Value;
            }
            else
            {
                MessageBox.Show("La fecha de vencimiento debe ser menor o igual a la fecha del sistema");
                this.fechaVencimientoInput.Value = DateTime.Today;
            }
        }

    }
}
