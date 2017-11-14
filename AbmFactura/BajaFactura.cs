using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private FacturaDAO<Factura> facturaDao;

        public BajaFactura()
        {
            InitializeComponent();
            this.facturaDao = new FacturaDAO<Factura>();
            this.facturaACargar = new Factura();
        }

        private void cargarDatos()
        {
            this.numeroInput.Text = this.facturaACargar.numero.ToString();
            this.fechaAltaInput.Value = this.facturaACargar.fechaAlta;
            this.fechaVencimientoInput.Value = this.facturaACargar.fechaVencimiento;
        }

        private void darDeBaja()
        {
            if (!this.facturaACargar.pagada && this.facturaACargar.idRendicion == 0)
            {
                int result = this.facturaDao.deleteFactura(this.facturaACargar);
                if (result == 1)
                {
                    MessageBox.Show("Se dio de baja de manera exitosa.");
                }
                else
                {
                    MessageBox.Show("No pudo realizarse la baja, intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("La factura se encuentra pagada o ya fue rendida.");
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
                    this.botonBaja.Enabled = true;
                    this.cargarDatos();
                }
            }
        }

        // Boton Baja
        private void botonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                this.darDeBaja();
            }catch(SqlException s){
                MessageBox.Show("Hubo un error en la baja de la factura.");
            }
            this.facturaACargar = new Factura();
            this.numeroInput.Clear();
            Utils.clearTextBoxes(this);
            this.botonBaja.Enabled = false;
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
