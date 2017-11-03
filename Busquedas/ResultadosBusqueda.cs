using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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
    partial class ResultadosBusqueda : Form
    {

        // Atributos
        private Cliente clienteSeleccionado;

        private Rol rolSeleccionado;
        private List<Rol> rolesEncontrados;
        private RolDAO<Rol> rolDao;

        // Constructores
        public ResultadosBusqueda(Rol rol)
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.cargarDataGridRoles();
        }

        public ResultadosBusqueda(List<Cliente> clientesACargar)
        {
            InitializeComponent();
        }

        private void cargarDataGridRoles()
        {
            this.rolesEncontrados = this.rolDao.findRol();

            DataTable resultadosRoles = new DataTable();

            resultadosRoles.Columns.Add("Nombre");
            resultadosRoles.Columns.Add("Descripcion");
            resultadosRoles.Columns.Add("Habilitado");

            foreach (Rol rolActual in this.rolesEncontrados)
            {
                resultadosRoles.Rows.Add(rolActual.nombre, rolActual.descripcion, rolActual.habilitado);
            }

            resultadosGrid.DataSource = resultadosRoles;
        }

        public void cargarDataGridClientes(List<Cliente> clientes)
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

        public Rol getRolSeleccionado()
        {
            return this.rolSeleccionado;
        }

        public Cliente getClienteSeleccionado()
        {
            return this.clienteSeleccionado;
        }

        // Eventos
        // Boton Aceptar
        private void aceptarButton_Click(object sender, EventArgs e)
        {
            int index = this.resultadosGrid.SelectedCells[0].RowIndex;
            this.rolSeleccionado = new Rol();

            String nombreRol = this.resultadosGrid.Rows[index].Cells[0].Value.ToString();

            this.rolSeleccionado = this.rolesEncontrados.Find(x => x.nombre.Equals(nombreRol));

            this.Close();
        }

        // Boton Volver
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
