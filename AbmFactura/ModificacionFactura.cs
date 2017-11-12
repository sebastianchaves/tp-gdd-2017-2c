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

namespace PagoAgilFrba.AbmFactura
{
    public partial class ModificacionFactura : Form
    {

        private Factura facturaACargar;
        private Factura facturaModificada;
        private FacturaDAO<Factura> facturaDao;

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



    }
}
