using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;

namespace PagoAgilFrba.AbmRol
{
    public partial class BajaRol : Form
    {

        private RolDAO<Rol> rolDao;
        private List<Rol> rolesEncontrados;
        private Rol rolSeleccionado;

        public BajaRol()
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.cargarRoles();
        }

        private void cargarRoles()
        {
            this.rolesEncontrados = this.rolDao.findRol();

            DataTable resultadosRoles = new DataTable();

            resultadosRoles.Columns.Add("Nombre");
            resultadosRoles.Columns.Add("Descripcion");
            resultadosRoles.Columns.Add("Habilitado");

            foreach (Rol rol in this.rolesEncontrados)
            {
                resultadosRoles.Rows.Add(rol.nombre, rol.descripcion, rol.habilitado);
            }

            this.rolesEncontradosGrid.DataSource = resultadosRoles;
        }

        private void seleccionarRol()
        {
            this.rolesEncontradosGrid.Select();
            int index = rolesEncontradosGrid.SelectedCells[0].RowIndex;
            
            String nombreRol = this.rolesEncontradosGrid.Rows[index].Cells[0].Value.ToString();

            this.rolSeleccionadoInput.Text = nombreRol;

            this.rolSeleccionado = this.rolesEncontrados.Find(x => x.nombre.Equals(nombreRol));
        }

        // Eventos
        // Boton Deshabilitar
        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {
            if (this.rolSeleccionado.habilitado)
            {
                this.rolSeleccionado.habilitado = false;
                this.rolDao.updateRol(this.rolSeleccionado);
                this.cargarRoles();
            }
            else
            {
                MessageBox.Show("Ya se encuentra deshabilitado");
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form Load
        private void BajaRol_Load(object sender, EventArgs e)
        {
            this.seleccionarRol();
        }

        // Cell Click
        private void rolesEncontradosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.seleccionarRol();
        }

    }
}
