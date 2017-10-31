using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
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

namespace PagoAgilFrba.Busquedas
{
    public partial class BusquedaCliente : Form
    {

        private ClienteDAO<Cliente> clienteDao;
        private Cliente clienteBuscado;
        private Cliente clienteEncontrado;

        public BusquedaCliente()
        {
            InitializeComponent();         
            this.clienteDao = new ClienteDAO<Cliente>();
            this.clienteBuscado = new Cliente();
            this.clienteEncontrado = new Cliente();
        }

        public Cliente getClienteEncontrado()
        {
            return this.clienteEncontrado;
        }

        // Eventos
        // Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            List<Cliente> resultados = this.clienteDao.findCliente(this.clienteBuscado.nombre, 
                                                        this.clienteBuscado.apellido, 
                                                        this.clienteBuscado.dni);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No existe ningún cliente que concuerde con esos parámetros.");
            }
            else
            {
                using (ResultadosBusqueda resultadosForm = new ResultadosBusqueda())
                {
                    resultadosForm.cargarDataGridClientes(resultados);
                    resultadosForm.ShowDialog(this);
                    this.clienteEncontrado = resultadosForm.getClienteSeleccionado();
                }
                this.Close();
            }

        }

        // Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga Cliente
        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.clienteBuscado.nombre = this.nombreInput.Text;
        }

        // Apellido
        private void apellidoInput_Leave(object sender, EventArgs e)
        {
            this.clienteBuscado.apellido = this.apellidoInput.Text;
        }

        // DNI
        private void dniInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.clienteBuscado.dni = Int32.Parse(dniInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, dniTooltip, dniInput);
            }
        }
    
    }
}
