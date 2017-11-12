using PagoAgilFrba.Busquedas;
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
    public partial class BajaFactura : Form
    {

        private Factura facturaACargar;

        public BajaFactura()
        {
            InitializeComponent();
            this.facturaACargar = new Factura();
        }

        private void cargarDatos()
        {
            this.numeroInput.Text = this.facturaACargar.numero.ToString();
            this.fechaAltaInput.Value = this.facturaACargar.fechaAlta;
            this.fechaVencimientoInput.Value = this.facturaACargar.fechaVencimiento;
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
                    this.botonBaja.Enabled = true;
                    this.cargarDatos();
                }
            }
        }

        // Boton Baja
        private void botonBaja_Click(object sender, EventArgs e)
        {

        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
