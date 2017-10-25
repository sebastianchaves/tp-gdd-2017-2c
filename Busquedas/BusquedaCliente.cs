using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
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
    public partial class BusquedaCliente : Form
    {

        // Atributos
        private IList<Cliente> resultados;
        private IList<Cliente> clientes;
        private ClienteDAO clienteDao;
        private Util utils;
        private DataGridView resultadosGrid;

        // Constructores
        public BusquedaCliente(DataGridView resultadosGrid)
        {
            InitializeComponent();

            this.utils = new Util();
            this.clienteDao = new ClienteDAO();
            this.resultadosGrid = resultadosGrid;
        }

        // Metodos
        private String cargarNombre()
        {
            return nombreInput.Text;
        }

        private String cargarApellido()
        {
            return apellidoInput.Text;
        }

        private int cargarDni()
        {
            try
            {
                int dni = Int32.Parse(dniInput.Text);
                return dni;
            }
            catch (Exception ex)
            {
                utils.catchearErrorFormato(ex, dniTooltip, dniInput);
                return 0;
            }
        }

        private void cargarDataGridClientes(IList<Cliente> clientes)
        {
            this.clientes = clientes;

            DataTable resultadosClientes = new DataTable();

            resultadosClientes.Columns.Add("Nombre");
            resultadosClientes.Columns.Add("Apellido");
            resultadosClientes.Columns.Add("DNI");
            resultadosClientes.Columns.Add("Mail");

            foreach (Cliente cliente in clientes)
            {
                resultadosClientes.Rows.Add(cliente.nombre, cliente.apellido, cliente.dni, cliente.mail);
            }
            resultadosGrid.DataSource = resultadosClientes;
        }

        // Eventos
        // Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            resultados = this.clienteDao.findCliente(this.cargarNombre(), 
                                                        this.cargarApellido(), 
                                                        this.cargarDni());

            if (resultados.Count() == 0)
            {
                MessageBox.Show("No existe ningún cliente que concuerde con esos parámetros.");
            }
            else if (resultados.Count() > 0)
            {
                cargarDataGridClientes(resultados);
                this.Close();
            }

        }

        // Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
