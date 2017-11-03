using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.DAOs;
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

namespace PagoAgilFrba.AbmRol
{
    public partial class ModificacionRol : Form
    {

        private RolDAO<Rol> rolDao;
        private Rol rolSeleccionado;

        public ModificacionRol()
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
        }

        private void cargarDatosRol()
        {
            this.nombreInput.Text = this.rolSeleccionado.nombre;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (ResultadosBusqueda resultadosBusqueda = new ResultadosBusqueda(this.rolSeleccionado))
            {
                var result = resultadosBusqueda.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    this.rolSeleccionado = new Rol();
                    this.rolSeleccionado = resultadosBusqueda.getRolSeleccionado();
                    this.cargarDatosRol();
                }
            }
        }

        // Boton Actualizar
        private void botonActualizar_Click(object sender, EventArgs e)
        {

        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
