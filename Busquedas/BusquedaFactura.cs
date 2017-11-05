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

namespace PagoAgilFrba.Busquedas
{
    public partial class BusquedaFactura : Form
    {

        private FacturaDAO<Factura> facturaDao;
        private Factura facturaEncontrada;

        private int numeroABuscar;

        public BusquedaFactura()
        {
            InitializeComponent();

            this.facturaDao = new FacturaDAO<Factura>();
        }

        private Boolean algunFiltroCompleto()
        {
            return this.numeroInput.Text != "";
        }

        public Factura getFacturaEncontrada()
        {
            return this.facturaEncontrada;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.algunFiltroCompleto())
            {
                List<Factura> resultados = this.facturaDao.findFactura(this.numeroABuscar);

                if (resultados.Count() == 0)
                {
                    MessageBox.Show("No existe ninguna factura que concuerde con esos parámetros.");
                }
                else if (resultados.Count() > 0)
                {
                    using (ResultadosBusqueda resultadosForm = new ResultadosBusqueda(resultados))
                    {
                        resultadosForm.ShowDialog(this);
                        this.facturaEncontrada = resultadosForm.getFacturaSeleccionada();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete alguno de los filtros disponibles");
            }
        }
        
        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargando Datos
        // Numero
        private void numeroInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.numeroABuscar = Int32.Parse(this.numeroInput.Text);
            }
            catch(Exception ex)
            {
                Utils.catchearErrorFormato(ex, numeroTooltip, numeroInput);
            }
        }

    }
}
