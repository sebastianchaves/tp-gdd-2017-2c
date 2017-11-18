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
        private PagoFacturaDAO<PagoFactura> pagoFacturaDao;

        private Boolean devolucionEnCurso;
        private Boolean minimoDevoluciones;

        public DevolucionFacturaForm()
        {
            InitializeComponent();

            this.devolucionDao = new DevolucionDAO<Devolucion>();
            this.tipoDevolucionDao = new TipoDevolucionDAO<TipoDevolucion>();
            this.devolucionFacturaDao = new DevolucionFacturaDAO<DevolucionFactura>();
            this.pagoFacturaDao = new PagoFacturaDAO<PagoFactura>();

            this.nuevaDevolucion = new Devolucion();
            this.nuevaDevolucionFactura = new DevolucionFactura();
            this.facturaACargar = new Factura();

            this.devolucionEnCurso = false;
            this.minimoDevoluciones = true;
        }

        private void devolverFactura()
        {
            if (this.facturaACargar != null && this.facturaACargar.id != 0)
            {
                this.nuevaDevolucionFactura.idFactura = facturaACargar.id;
                this.nuevaDevolucionFactura.idDevolucion = nuevaDevolucion.id;
                this.devolucionFacturaDao.agregarDevolucionFactura(this.nuevaDevolucionFactura);
                this.eliminarPagoFactura();

                this.nuevaDevolucionFactura = new DevolucionFactura();
                this.facturaACargar = new Factura();
                
                this.facturaInput.Clear();

                this.minimoDevoluciones = true;

                MessageBox.Show("Devolucion agregada!");
            }
            else
            {
                MessageBox.Show("No cargo ninguna factura.");
            }
        }

        private void eliminarPagoFactura()
        {
            PagoFactura pagoFactura = new PagoFactura();

            pagoFactura.idFactura = facturaACargar.id;
            pagoFactura.idPago = this.pagoFacturaDao.findByIdFactura(facturaACargar.id).ElementAt(0).idPago;

            this.pagoFacturaDao.delete(pagoFactura);
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

        private void deshabilitarCamposDevolucion()
        {
            this.motivoInput.Enabled = false;
        }

        private void cargarDatosDevolucion()
        {
            this.nuevaDevolucion.fecha = this.fechaInput.Value;
            this.nuevaDevolucion.motivo = this.motivoInput.Text;
            this.nuevaDevolucion.idTipoDevolucion = this.tipoDevolucionDao.findTipoDevolucion("devolucion_factura").ElementAt(0).id;
        }

        private void cargarDatosFactura()
        {
            this.facturaInput.Text = this.facturaACargar.numero.ToString();
        }

        private void crearNuevaDevolucion()
        {
            if (this.camposCompletos())
            {
                this.deshabilitarCamposDevolucion();
                this.habilitarCamposFactura();
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
            return MessageBox.Show("La devolucion actual no registra facturas devueltas...\n ¿Desea cancelarla?",
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
            this.facturaInput.Text = "";
            this.facturaACargar = new Factura();

            using (BusquedaFactura busquedaForm = new BusquedaFactura())
            {
                busquedaForm.ShowDialog(this);
                this.facturaACargar = busquedaForm.getFacturaEncontrada();

                if (this.facturaACargar != null)
                {
                    if (this.facturaACargar.idRendicion == 0 && this.facturaACargar.pagada)
                    {
                        this.cargarDatosFactura();
                        MessageBox.Show("Factura cargada con exito!.");
                    }
                    else
                    {
                        if (this.facturaACargar.idRendicion != 0)
                        {
                            MessageBox.Show("La factura ya se encuentra rendida.");
                        }
                        if (!this.facturaACargar.pagada)
                        {
                            MessageBox.Show("La factura no ha sido pagada.");
                        }
                        this.facturaACargar = new Factura();
                    }
                }
                else
                {
                    MessageBox.Show("No se cargo ninguna factura!");
                    this.facturaACargar = new Factura();
                }
            }
        }

        // Boton Devolver
        private void botonDevolver_Click(object sender, EventArgs e)
        {
            this.devolverFactura();
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
                this.botonNueva.Enabled = true;
                this.botonCrear.Enabled = true;
            }
            else
            {
                this.botonNueva.Enabled = false;
                this.botonCrear.Enabled = false;
            }
        }

        // Boton Nueva Devolucion
        private void botonNueva_Click(object sender, EventArgs e)
        {
            if (!this.minimoDevoluciones)
            {
                if (this.devolucionSinRegistros() == DialogResult.Yes)
                {
                    this.eliminarDevolucionActual();

                    this.botonDevolver.Enabled = false;
                    this.motivoInput.Enabled = true;
                    
                    this.facturaInput.Clear();
                    
                    this.facturaACargar = new Factura();

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

                this.facturaInput.Clear();

                this.motivoInput.Clear();

                this.facturaACargar = new Factura();
                this.nuevaDevolucion = new Devolucion();
                this.devolucionEnCurso = false;
            }
        }

        // Boton Crear Devolucion
        private void botonCrear_Click(object sender, EventArgs e)
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
