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
    public partial class DevolucionRendicionForm : Form
    {

        private Devolucion nuevaDevolucion;
        private DevolucionRendicion nuevaDevolucionRendicion;
        private Rendicion rendicionACargar;

        private DevolucionDAO<Devolucion> devolucionDao;
        private TipoDevolucionDAO<TipoDevolucion> tipoDevolucionDao;
        private DevolucionRendicionDAO<DevolucionRendicion> devolucionRendicionDao;

        public DevolucionRendicionForm()
        {
            InitializeComponent();

            this.devolucionDao = new DevolucionDAO<Devolucion>();
            this.tipoDevolucionDao = new TipoDevolucionDAO<TipoDevolucion>();
            this.devolucionRendicionDao = new DevolucionRendicionDAO<DevolucionRendicion>();

            this.nuevaDevolucion = new Devolucion();
            this.nuevaDevolucionRendicion = new DevolucionRendicion();
            this.rendicionACargar = new Rendicion();
        }

        private void devolverRendicion()
        {
            if (hayRendicion())
            {
                this.nuevaDevolucionRendicion.idRendicion = rendicionACargar.id;
                this.nuevaDevolucionRendicion.idDevolucion = nuevaDevolucion.id;
                this.devolucionRendicionDao.agregarDevolucionRendicion(this.nuevaDevolucionRendicion);

                MessageBox.Show("Devolucion agregada!");
            }
            else
            {
                MessageBox.Show("No cargo ninguna rendicion.");
            }
        }

        private Boolean hayRendicion()
        {
            return this.rendicionACargar.id != 0;
        }

        private Boolean camposCompletos()
        {
            return this.motivoInput.Text != "";
        }

        private void habilitarCamposRendicion()
        {
            this.rendicionInput.Enabled = true;
        }

        private void deshabilitarCamposRendicion()
        {
            this.rendicionInput.Enabled = false;
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
            this.rendicionInput.Text = this.rendicionACargar.nombreEmpresa;
            this.mesInput.Text = this.rendicionACargar.fecha.Month.ToString();
            this.anioInput.Text = this.rendicionACargar.fecha.Year.ToString();

            this.nuevaDevolucion.fecha = this.fechaInput.Value;
            this.nuevaDevolucion.motivo = this.motivoInput.Text;
            this.nuevaDevolucion.idTipoDevolucion = this.tipoDevolucionDao.findTipoDevolucion("devolucion_rendicion").ElementAt(0).id;
        }

        private void crearNuevaDevolucion()
        {
            if (this.camposCompletos())
            {
                this.deshabilitarCamposDevolucion();
                this.habilitarCamposRendicion();
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
            using (BusquedaRendicion busquedaForm = new BusquedaRendicion())
            {
                busquedaForm.ShowDialog(this);
                this.rendicionACargar = busquedaForm.getRendicionEncontrada();

                if (this.rendicionACargar != null)
                {
                    this.botonDevolver.Enabled = true;
                    this.cargarDatos();
                }
            }
        }

        // Boton Devolver
        private void botonDevolver_Click(object sender, EventArgs e)
        {
            this.devolverRendicion();
            this.nuevaDevolucionRendicion = new DevolucionRendicion();
            this.botonDevolver.Enabled = false;
            this.rendicionInput.Clear();
            this.mesInput.Clear();
            this.anioInput.Clear();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton Nueva Devolucion
        private void botonNuevaDevolucion_Click(object sender, EventArgs e)
        {
            this.motivoInput.Clear();
            this.habilitarCamposDevolucion();
           
            this.botonCrearDevolucion.Enabled = true;
            this.botonBuscar.Enabled = false;
            this.botonDevolver.Enabled = false;
            
            this.rendicionInput.Clear();
            this.anioInput.Clear();
            this.mesInput.Clear();

            this.nuevaDevolucion = new Devolucion();
        }

        // Boton Crear Devolucion
        private void botonCrearDevolucion_Click(object sender, EventArgs e)
        {
            this.botonCrearDevolucion.Enabled = false;
            this.crearNuevaDevolucion();
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
