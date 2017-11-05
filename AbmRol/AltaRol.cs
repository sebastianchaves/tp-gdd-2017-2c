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
using PagoAgilFrba.Modelo.Utils;

namespace PagoAgilFrba.AbmRol
{
    public partial class AltaRol : Form
    {

        private FuncionalidadDAO<Funcionalidad> funcionalidadDao;
        private RolDAO<Rol> rolDao;
        private Rol nuevoRol;
        private List<Funcionalidad> funcionalidadesEncontradas;
        private Dictionary<int, String> funcionalidadesIDs;

        public AltaRol()
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.funcionalidadDao = new FuncionalidadDAO<Funcionalidad>();
            this.nuevoRol = new Rol();
            this.funcionalidadesIDs = new Dictionary<int, String>();

            this.cargarFuncionalidadesDisponibles();
        }

        private void cargarFuncionalidadesDisponibles()
        {
            this.funcionalidadesCheckbox.Items.Clear();

            this.funcionalidadesEncontradas = this.funcionalidadDao.findFuncionalidades();

            foreach (Funcionalidad funcionalidad in this.funcionalidadesEncontradas)
            {
                this.funcionalidadesCheckbox.Items.Insert(0, funcionalidad.nombre);
                this.funcionalidadesIDs.Add(funcionalidad.id, funcionalidad.nombre);
            }
        }

        private void cargarRol()
        {
            this.nuevoRol.habilitado = true;

            if (camposCompletos())
            {
                this.rolDao.agregarRol(nuevoRol);
                MessageBox.Show("Rol agregado!");
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes.");
            }
        }

        private Boolean camposCompletos()
        {
            return (nombreInput.Text != "") &&
                    funcionalidadesCheckbox.CheckedItems.Count != 0;
        }

        private void cargarFuncionalidades()
        {
            foreach (String itemChecked in this.funcionalidadesCheckbox.CheckedItems)
            {
                var id = this.funcionalidadesIDs.FirstOrDefault(x => x.Value == itemChecked).Key;

                this.nuevoRol.funcionalidades.Add(this.funcionalidadesEncontradas.Find(x => x.id == id));
            }
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.cargarFuncionalidades();
            this.cargarRol();
            this.nuevoRol = new Rol();
            Utils.clearTextBoxes(this);
            this.funcionalidadesCheckbox.Items.Clear();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.nuevoRol.nombre = this.nombreInput.Text;
        }

    }
}
