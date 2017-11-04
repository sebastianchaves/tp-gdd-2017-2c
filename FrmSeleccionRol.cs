using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    partial class FrmSeleccionRol : Form
    {

        private List<Rol> rolesEncontrados;
        private Rol rolSeleccionado;

        public FrmSeleccionRol(List<Rol> roles)
        {
            InitializeComponent();

            this.cargarRoles(roles);
        }

        private void cargarRoles(List<Rol> roles)
        {
            this.rolesEncontrados = roles;

            var dataSource = new List<String>();

            for (int i = 0; i < this.rolesEncontrados.Count; i++)
            {
                this.rolesEncontrados.ElementAt(i).indexCombo = i;
                dataSource.Add(this.rolesEncontrados.ElementAt(i).nombre);
            }

            this.rolesCombo.DataSource = dataSource;
        }

        private Rol rubroByIndex(int index)
        {
            return this.rolesEncontrados.Find(rol => rol.indexCombo.Equals(index));
        }

        public Rol getRolSeleccionado()
        {
            return this.rolSeleccionado;
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
