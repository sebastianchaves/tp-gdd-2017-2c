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
        private List<Funcionalidad> funcionalidadesEncontradas;

        private RolDAO<Rol> rolDao;
        private Rol nuevoRol;
        
        private Dictionary<int, String> funcionalidadesIDs;

        private RolFuncionalidadDAO<RolFuncionalidad> rolFuncionalidadDao;

        public AltaRol()
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.funcionalidadDao = new FuncionalidadDAO<Funcionalidad>();
            this.nuevoRol = new Rol();
            this.funcionalidadesIDs = new Dictionary<int, String>();

            this.rolFuncionalidadDao = new RolFuncionalidadDAO<RolFuncionalidad>();

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

            if (camposCompletos() && hayFuncionalidades())
            {
                int idNuevoRol = this.rolDao.agregarRol(nuevoRol);
                this.insertarFuncionalidadesRol(this.nuevoRol.funcionalidades, idNuevoRol);
                MessageBox.Show("Rol agregado!");
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes.");
            }
        }

        private void insertarFuncionalidadesRol(List<Funcionalidad> funcionalidades, int idNuevoRol)
        {
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                RolFuncionalidad rolFuncionalidad = new RolFuncionalidad();
                rolFuncionalidad.idFuncionalidad = funcionalidad.id;
                rolFuncionalidad.idRol = idNuevoRol;

                this.rolFuncionalidadDao.insert(rolFuncionalidad);
            }
        }

        private Boolean hayFuncionalidades()
        {
            return this.nuevoRol.funcionalidades.Count > 0;
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

        private void uncheckFuncionalidades()
        {
            for (int i = 0; i < this.funcionalidadesCheckbox.Items.Count; i++)
            {
                if (this.funcionalidadesCheckbox.GetItemCheckState(i).Equals(CheckState.Checked))
                {
                    this.funcionalidadesCheckbox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.cargarFuncionalidades();
            this.cargarRol();
            this.nuevoRol = new Rol();
            this.nombreInput.Clear();
            this.uncheckFuncionalidades();
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
