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

namespace PagoAgilFrba.Busquedas
{
    public partial class ResultadosBusqueda : Form
    {

        // Atributos
        private Cliente clienteSeleccionado;

        // Constructores
        public ResultadosBusqueda()
        {
            InitializeComponent();
        }

        // Metodos
        public void cargarDataGridClientes(IList<Cliente> clientes)
        {
            DataTable resultadosClientes = new DataTable();

            resultadosClientes.Columns.Add("DNI");
            resultadosClientes.Columns.Add("Apellido");
            resultadosClientes.Columns.Add("Nombre");
            resultadosClientes.Columns.Add("Mail");

            foreach (Cliente cliente in clientes)
            {
                resultadosClientes.Rows.Add(cliente.dni, cliente.apellido, cliente.nombre, cliente.mail);
            }
            resultadosGrid.DataSource = resultadosClientes;
        }

        public Cliente getClienteSeleccionado()
        {
            return this.clienteSeleccionado;
        }

        // Eventos
        // Boton Aceptar
        private void aceptarButton_Click(object sender, EventArgs e)
        {
            var clienteIndex = resultadosGrid.SelectedCells[0].RowIndex;
            this.clienteSeleccionado = new Cliente();

            this.clienteSeleccionado.dni = Int32.Parse(resultadosGrid.Rows[clienteIndex].Cells[0].Value.ToString());
        }

        // Boton Volver
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
