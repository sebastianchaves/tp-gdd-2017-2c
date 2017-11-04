using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class BajaCliente : Form
    {

        private Cliente clienteSeleccionado;

        public BajaCliente()
        {
            InitializeComponent();

        }

        private void cargarDatos()
        {
            this.nombreInput.Text = this.clienteSeleccionado.nombre;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaForm = new BusquedaCliente())
            {
                busquedaForm.ShowDialog(this);
                this.clienteSeleccionado = busquedaForm.getClienteEncontrado();
                this.cargarDatos();
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton Deshabilitar
        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {


        }



    }
}
