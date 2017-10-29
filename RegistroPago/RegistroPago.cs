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
    public partial class RegistroPago : Form
    {

        // Atributos
        private DataTable tablaFacturas;

        // Constructores
        public RegistroPago()
        {
            InitializeComponent();
            this.iniciarFacturasGrid();
        }

        // Metodos
        private void iniciarFacturasGrid()
        {
            Utils.iniciarGrids(facturasGrid);
            this.tablaFacturas = new DataTable();
            this.tablaFacturas.Columns.Add("Numero");
        }

        private void cargarNuevaFactura(Factura nuevaFactura)
        {
            this.tablaFacturas.Rows.Add(nuevaFactura.numero);
            this.facturasGrid.DataSource = tablaFacturas;
        }

        // Eventos
        // Boton Cargar Factura
        private void botonCargarFactura_Click(object sender, EventArgs e)
        {
            using (CargaFactura cargaForm = new CargaFactura())
            {
                cargaForm.ShowDialog(this);

                Factura nuevaFactura = cargaForm.getNuevaFactura();

                if (nuevaFactura != null)
                {
                    this.cargarNuevaFactura(nuevaFactura);
                }
                else 
                {
                    MessageBox.Show("No se cargo ninguna factura, intente nuevamente.");
                }
                
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
