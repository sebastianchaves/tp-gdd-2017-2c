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
        private ClienteDAO clienteDao;
        private Utils utils;
        private Cliente clienteBuscado;

        // Constructores
        public BusquedaCliente()
        {
            InitializeComponent();

            this.utils = new Utils();
            this.clienteDao = new ClienteDAO();
            this.clienteBuscado = new Cliente();
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

        // Eventos
        // Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            IList <Cliente> resultados = this.clienteDao.findCliente(this.cargarNombre(), 
                                                        this.cargarApellido(), 
                                                        this.cargarDni());

            if (resultados.Count() == 0)
            {
                MessageBox.Show("No existe ningún cliente que concuerde con esos parámetros.");
            }
            else if (resultados.Count() > 0)
            {
                using (ResultadosBusqueda resultadosForm = new ResultadosBusqueda())
                {
                    resultadosForm.ShowDialog(this);
                    resultadosForm.cargarDataGridClientes(resultados);
                    this.clienteBuscado = resultadosForm.getClienteSeleccionado();
                }
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
