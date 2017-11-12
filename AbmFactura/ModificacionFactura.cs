using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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
        private Empresa empresaEncontrada;

        public ModificacionFactura()
        {
            InitializeComponent();

            this.facturaDao = new FacturaDAO<Factura>();
            this.facturaModificada = new Factura();
        }

        private void actualizarFactura()
        {

        }

        private void cargarDatos()
        {

        }

        private void habilitarCampos()
        {
            this.botonBuscarCliente.Enabled = true;
            this.botonBuscarEmpresa.Enabled = true;

            this.fechaAltaInput.Enabled = true;
            this.fechaVencimientoInput.Enabled = true;

            this.montoInput.Enabled = true;
            this.cantidadInput.Enabled = true;
        }

        private void deshabilitarCampos()
        {


        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaFactura busquedaForm = new BusquedaFactura())
            {
                busquedaForm.ShowDialog(this);
                this.facturaACargar = busquedaForm.getFacturaEncontrada();

                if (this.facturaACargar.id != 0)
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

            this.deshabilitarCampos();
            this.botonActualizar.Enabled = false;
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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



    }
}
