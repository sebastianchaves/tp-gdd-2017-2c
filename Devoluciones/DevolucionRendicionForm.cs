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

        private Boolean devolucionEnCurso;
        private Boolean minimoDevoluciones;
    
        public DevolucionRendicionForm()
        {
            InitializeComponent();

            this.devolucionDao = new DevolucionDAO<Devolucion>();
            this.tipoDevolucionDao = new TipoDevolucionDAO<TipoDevolucion>();
            this.devolucionRendicionDao = new DevolucionRendicionDAO<DevolucionRendicion>();

            this.nuevaDevolucion = new Devolucion();
            this.nuevaDevolucionRendicion = new DevolucionRendicion();

            this.devolucionEnCurso = false;
            this.minimoDevoluciones = true;
        }

        private void devolverRendicion()
        {
            if (this.rendicionACargar != null && this.rendicionACargar.id != 0)
            {
                if (!this.rendicionDevuelta())
                {
                    this.nuevaDevolucionRendicion.idRendicion = rendicionACargar.id;
                    this.nuevaDevolucionRendicion.idDevolucion = nuevaDevolucion.id;
                    this.devolucionRendicionDao.agregarDevolucionRendicion(this.nuevaDevolucionRendicion);

                    this.nuevaDevolucionRendicion = new DevolucionRendicion();
                    this.rendicionACargar = new Rendicion();

                    this.rendicionInput.Clear();
                    this.mesInput.Clear();
                    this.anioInput.Clear();

                    this.minimoDevoluciones = true;

                    MessageBox.Show("Devolucion agregada!");
                }
                else
                {
                    MessageBox.Show("Esta rendicion ya ha sido devuelta.");
                    this.nuevaDevolucionRendicion = new DevolucionRendicion();
                    this.rendicionACargar = new Rendicion();

                    this.rendicionInput.Clear();
                    this.mesInput.Clear();
                    this.anioInput.Clear();

                    this.minimoDevoluciones = true;
                }
            }
            else
            {
                MessageBox.Show("No cargo ninguna rendicion.");
            }
        }

        private Boolean rendicionDevuelta()
        {
            List<DevolucionRendicion> rendicionesDevueltas = this.devolucionRendicionDao.selectRendicion(this.rendicionACargar);
            return rendicionesDevueltas.Count > 0;
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

        private void cargarDatosDevolucion()
        {
            this.nuevaDevolucion.fecha = this.fechaInput.Value;
            this.nuevaDevolucion.motivo = this.motivoInput.Text;
            this.nuevaDevolucion.idTipoDevolucion = this.tipoDevolucionDao.findTipoDevolucion("devolucion_rendicion").ElementAt(0).id;
        }

        private void cargarDatosRendicion()
        {
            this.anioInput.Text = this.rendicionACargar.fecha.Year.ToString();
            this.mesInput.Text = this.rendicionACargar.fecha.Month.ToString();
            this.rendicionInput.Text = this.rendicionACargar.nombreEmpresa;
        }

        private void crearNuevaDevolucion()
        {
            if (this.camposCompletos())
            {
                this.deshabilitarCamposDevolucion();
                this.habilitarCamposRendicion();
                this.cargarDatosDevolucion();
                this.nuevaDevolucion.id = this.devolucionDao.agregarDevolucion(this.nuevaDevolucion);
                this.devolucionEnCurso = true;
                this.minimoDevoluciones = false;
            }
            else
            {
                MessageBox.Show("Complete el motivo de la devolucion.");
            }
        }

        private DialogResult devolucionSinRegistros()
        {
            return MessageBox.Show("La devolucion actual no registra rendiciones devueltas...\n ¿Desea cancelarla?",
                    "Cancelar Devolucion", MessageBoxButtons.YesNo);
        }

        private void eliminarDevolucionActual()
        {
            this.devolucionDao.deleteDevolucion(this.nuevaDevolucion);
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.anioInput.Text = "";
            this.mesInput.Text = "";
            this.rendicionInput.Text = "";

            using (BusquedaRendicion busquedaForm = new BusquedaRendicion())
            {
                busquedaForm.ShowDialog(this);
                this.rendicionACargar = busquedaForm.getRendicionEncontrada();

                if (this.rendicionACargar.id != 0)
                {
                    this.cargarDatosRendicion();
                }
                else
                {
                    MessageBox.Show("No se cargo ninguna rendicion!");
                    this.rendicionACargar = new Rendicion();
                }
            }
        }

        // Boton Devolver
        private void botonDevolver_Click(object sender, EventArgs e)
        {
            this.devolverRendicion();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            if (!this.minimoDevoluciones)
            {
                if (this.devolucionSinRegistros() == DialogResult.Yes)
                {
                    this.eliminarDevolucionActual();
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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

        // Text change Motivo Input
        private void motivoInput_TextChanged(object sender, EventArgs e)
        {
            if (this.motivoInput.Text != "")
            {
                this.botonNuevaDevolucion.Enabled = true;
                this.botonCrearDevolucion.Enabled = true;
            }
            else
            {
                this.botonNuevaDevolucion.Enabled = false;
                this.botonCrearDevolucion.Enabled = false;
            }
        }

        // Boton Nueva Devolucion
        private void botonNuevaDevolucion_Click(object sender, EventArgs e)
        {
            if (!this.minimoDevoluciones)
            {
                if (this.devolucionSinRegistros() == DialogResult.Yes)
                {
                    this.eliminarDevolucionActual();

                    this.botonDevolver.Enabled = false;
                    this.motivoInput.Enabled = true;

                    this.rendicionInput.Clear();
                    this.anioInput.Clear();
                    this.mesInput.Clear();

                    this.rendicionACargar = new Rendicion();

                    this.motivoInput.Clear();
                    this.nuevaDevolucion = new Devolucion();
                    this.devolucionEnCurso = false;
                    this.minimoDevoluciones = true;
                }
            }
            else
            {
                this.botonDevolver.Enabled = false;
                this.motivoInput.Enabled = true;

                this.rendicionInput.Clear();
                this.anioInput.Clear();
                this.mesInput.Clear();

                this.motivoInput.Clear();

                this.rendicionACargar = new Rendicion();
                this.nuevaDevolucion = new Devolucion();
                this.devolucionEnCurso = false;
            }
        }

        // Boton Crear Devolucion
        private void botonCrearDevolucion_Click(object sender, EventArgs e)
        {
            if (!this.devolucionEnCurso)
            {
                this.crearNuevaDevolucion();
                this.botonDevolver.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ya se encuentra una devolucion en curso.");
            }
        }

    }
}
