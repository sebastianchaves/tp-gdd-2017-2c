using PagoAgilFrba.Busquedas;
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

namespace PagoAgilFrba.Devoluciones
{
    public partial class DevolucionFacturaForm : Form
    {

        private Devolucion nuevaDevolucion;
        private DevolucionFactura nuevaDevolucionFactura;
        private Factura facturaACargar;

        private DevolucionDAO<Devolucion> devolucionDao;
        private TipoDevolucionDAO<TipoDevolucion> tipoDevolucionDao;
        private DevolucionFacturaDAO<DevolucionFactura> devolucionFacturaDao;

        public DevolucionFacturaForm()
        {
            InitializeComponent();

            this.devolucionDao = new DevolucionDAO<Devolucion>();
            this.tipoDevolucionDao = new TipoDevolucionDAO<TipoDevolucion>();
            this.devolucionFacturaDao = new DevolucionFacturaDAO<DevolucionFactura>();

            this.nuevaDevolucion = new Devolucion();
            this.nuevaDevolucionFactura = new DevolucionFactura();
            this.facturaACargar = new Factura();
        }

        private void devolverFactura()
        {
            if (hayFactura())
            {
                this.nuevaDevolucionFactura.idFactura = facturaACargar.id;
                this.nuevaDevolucionFactura.idDevolucion = nuevaDevolucion.id;
                this.devolucionFacturaDao.agregarDevolucionFactura(this.nuevaDevolucionFactura);

                MessageBox.Show("Devolucion agregada!");
            }
            else
            {
                MessageBox.Show("No cargo ninguna factura.");
            }
        }

        private Boolean hayFactura()
        {
            return this.facturaACargar.id != 0;
        }

        private Boolean camposCompletos()
        {
            return this.motivoInput.Text != "";
        }

        private void habilitarCamposFactura()
        {
            this.facturaInput.Enabled = true;
        }

        private void deshabilitarCamposFactura()
        {
            this.facturaInput.Enabled = false;
        }

        private void habilitarCamposDevolucion()
        {
            this.motivoInput.Enabled = true;
        }

        private void deshabilitarCamposDevolucion()
        {
            this.motivoInput.Enabled = false;
        }

        private void cargarDatos()
        {
            this.facturaInput.Text = this.facturaACargar.numero.ToString();

            this.nuevaDevolucion.fecha = this.fechaInput.Value;
            this.nuevaDevolucion.motivo = this.motivoInput.Text;
            this.nuevaDevolucion.idTipoDevolucion = this.tipoDevolucionDao.findTipoDevolucion("devolucion_factura").ElementAt(0).id;
        }

        private void crearNuevaDevolucion()
        {
            if (this.camposCompletos())
            {
                this.deshabilitarCamposDevolucion();
                this.habilitarCamposFactura();
                this.botonBuscar.Enabled = true;
                this.cargarDatos();
                this.nuevaDevolucion.id = this.devolucionDao.agregarDevolucion(this.nuevaDevolucion);
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
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
                    if (this.facturaACargar.idRendicion == 0 && !this.facturaACargar.pagada)
                    {
                        this.botonDevolver.Enabled = true;
                        this.cargarDatos();
                    }
                    else
                    {
                        if (this.facturaACargar.idRendicion != 0)
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
            this.nuevaDevolucionFactura = new DevolucionFactura();
            this.botonDevolver.Enabled = false;
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

        // Crear Devolucion
        private void botonCrearDevolucion_Click(object sender, EventArgs e)
        {
            this.botonCrearDevolucion.Enabled = false;
            this.crearNuevaDevolucion();
        }

        // Nueva Devolucion
        private void botonNueva_Click(object sender, EventArgs e)
        {
            this.motivoInput.Clear();
            this.habilitarCamposDevolucion();
            this.botonCrearDevolucion.Enabled = true;
            this.nuevaDevolucion = new Devolucion();
        }

    }
}
