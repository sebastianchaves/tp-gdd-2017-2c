using PagoAgilFrba.Busquedas;
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

namespace PagoAgilFrba.Devoluciones
{
    public partial class DevolucionFacturaForm : Form
    {

        private Devolucion nuevaDevolucion;
        private DevolucionFactura nuevaDevolucionFactura;
        private Factura facturaACargar;

        private DevolucionDAO<Devolucion> devolucionDao;

        public DevolucionFacturaForm()
        {
            InitializeComponent();

            this.devolucionDao = new DevolucionDAO<Devolucion>();

            this.nuevaDevolucion = new Devolucion();
            this.nuevaDevolucionFactura = new DevolucionFactura();
            this.facturaACargar = new Factura();
        }

        private void devolverFactura()
        {
            if (camposCompletos())
            {
                this.devolucionDao.agregarDevolucion(this.nuevaDevolucion);
                MessageBox.Show("Devolucion agregada!");
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
        }

        private Boolean camposCompletos()
        {
            return this.motivoInput.Text != "";
        }

        private void habilitarCampos()
        {
            this.facturaInput.Enabled = true;
            this.fechaInput.Enabled = true;
            this.motivoInput.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.facturaInput.Enabled = false;
            this.fechaInput.Enabled = false;
            this.motivoInput.Enabled = false;
        }

        private void cargarDatos()
        {
            this.facturaInput.Text = this.facturaACargar.numero.ToString();

            this.nuevaDevolucion.fecha = this.fechaInput.Value;
            this.nuevaDevolucion.motivo = this.motivoInput.Text;

            this.nuevaDevolucion.idTipoDevolucion = this.devolucionDao.findTipoDevolucion("devolucion_factura").ElementAt(0).id;

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
                    if (this.facturaACargar.idRendicion != 0 && !this.facturaACargar.pagada)
                    {
                        this.botonDevolver.Enabled = true;
                        this.cargarDatos();
                        this.habilitarCampos();
                    }
                    else
                    {
                        if (this.facturaACargar.idRendicion == 0)
                        {
                            MessageBox.Show("La factura ya se encuentra rendida");
                        }
                        if (this.facturaACargar.pagada)
                        {
                            MessageBox.Show("La factura ya se encuentra pagada");
                        }
                    }
                }
            }
        }

        // Boton Devolver
        private void botonDevolver_Click(object sender, EventArgs e)
        {
            this.devolverFactura();

            this.deshabilitarCampos();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargando Datos
        // Fecha
        private void fechaInput_Leave(object sender, EventArgs e)
        {
            this.nuevaDevolucion.fecha = this.fechaInput.Value;
        }

        // Motivo
        private void motivoInput_Leave(object sender, EventArgs e)
        {
            this.nuevaDevolucion.motivo = this.motivoInput.Text;
        }

    }
}
