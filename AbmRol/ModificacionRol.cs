using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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

namespace PagoAgilFrba.AbmRol
{
    public partial class ModificacionRol : Form
    {

        private FuncionalidadDAO<Funcionalidad> funcionalidadDao;
        private RolDAO<Rol> rolDao;
        private Rol rolSeleccionado;
        private Rol rolModificado;
        private Dictionary<int, String> funcionalidadesIDs;
        private List<Funcionalidad> funcionalidadesEncontradas;
        private List<Funcionalidad> funcionalidadesDisponibles;

        public ModificacionRol()
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.funcionalidadDao = new FuncionalidadDAO<Funcionalidad>();
            this.rolModificado = new Rol();
            this.funcionalidadesIDs = new Dictionary<int, String>();

            this.cargarFuncionalidadesDisponibles();
        }

        private void cargarFuncionalidadesDisponibles()
        {
            this.funcionalidadesCheckbox.Items.Clear();

            this.funcionalidadesDisponibles = this.funcionalidadDao.findFuncionalidades();

            for (int i = 0; i < this.funcionalidadesDisponibles.Count; i++)
            {
                this.funcionalidadesDisponibles.ElementAt(i).checklistIndex = i;
                this.funcionalidadesCheckbox.Items.Insert(0, this.funcionalidadesDisponibles.ElementAt(i).nombre);
                this.funcionalidadesIDs.Add(this.funcionalidadesDisponibles.ElementAt(i).id, this.funcionalidadesDisponibles.ElementAt(i).nombre);
            }
        }

        private void actualizarRol()
        {
            if (this.camposCompletos())
            {
                this.cargarFuncionalidades();

                if (!this.rolModificado.habilitado && this.rolSeleccionado.habilitado)
                {
                    this.rolDao.darDeBajaRolEnTodosLosUsuarios(this.rolModificado);
                }
                
                this.rolDao.updateRol(this.rolModificado);
                MessageBox.Show("Datos actualizados!");
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }

        }

        private Boolean camposCompletos()
        {
            return (this.nombreInput.Text != "") && this.algunaFuncionalidadElegida();
        }

        private Boolean algunaFuncionalidadElegida()
        {
            return this.funcionalidadesCheckbox.CheckedItems.Count != 0;
        }

        private void cargarDatosRol()
        {
            this.rolSeleccionadoInput.Text = this.rolSeleccionado.nombre;

            this.nombreInput.Text = this.rolSeleccionado.nombre;
            this.rolModificado.nombre = this.rolSeleccionado.nombre;

            this.checkearFuncionalidades();

            this.habilitarDeshabilitar();
        }

        private void checkearFuncionalidades()
        {
            this.funcionalidadesEncontradas = this.funcionalidadDao.obtenerFuncionalidadesPorRol(this.rolSeleccionado.nombre);

            foreach (Funcionalidad funcionalidad in this.funcionalidadesEncontradas)
            {
                for (int i = 0; i < this.funcionalidadesEncontradas.Count; i++)
                {
                    this.funcionalidadesCheckbox.SetItemChecked(this.funcionalidadesEncontradas.ElementAt(i).checklistIndex, true);
                }
            }
        }

        private void habilitarDeshabilitar()
        {
            this.habilitadoRadioButton.Enabled = true;
            this.deshabilitadoRadioButton.Enabled = true;

            if (this.rolSeleccionado.habilitado)
            {
                this.habilitadoRadioButton.PerformClick();
                this.rolModificado.habilitado = true;
            }
            else
            {
                this.deshabilitadoRadioButton.PerformClick();
                this.rolModificado.habilitado = false;
            }
        }

        private void cargarFuncionalidades()
        {
            this.funcionalidadesEncontradas = this.funcionalidadDao.obtenerFuncionalidadesPorRol(this.rolSeleccionado.nombre);

            foreach (String itemChecked in this.funcionalidadesCheckbox.CheckedItems)
            {
                var id = this.funcionalidadesIDs.FirstOrDefault(x => x.Value == itemChecked).Key;

                this.rolModificado.funcionalidades.Add(this.funcionalidadesEncontradas.Find(x => x.id == id));
            }
        }

        private void habilitarCampos()
        {
            this.nombreInput.Enabled = true;
            this.funcionalidadesCheckbox.Enabled = true;
            this.habilitadoRadioButton.Enabled = true;
            this.deshabilitadoRadioButton.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.nombreInput.Enabled = false;
            this.funcionalidadesCheckbox.Enabled = false;
            this.habilitadoRadioButton.Enabled = false;
            this.deshabilitadoRadioButton.Enabled = false;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (ResultadosBusqueda resultadosBusqueda = new ResultadosBusqueda(this.rolSeleccionado))
            {
                var result = resultadosBusqueda.ShowDialog(this);
                this.rolSeleccionado = new Rol();
                this.rolSeleccionado = resultadosBusqueda.getRolSeleccionado();

                if (this.rolSeleccionado != null)
                {
                    this.habilitarCampos();
                    this.cargarDatosRol();
                    this.botonActualizar.Enabled = true;
                }

            }
        }

        // Boton Actualizar
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            this.actualizarRol();
            Utils.clearTextBoxes(this);
            this.rolModificado = new Rol();
            this.rolSeleccionado = new Rol();
            this.deshabilitarCampos();
            this.botonActualizar.Enabled = false;
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargando Datos
        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.rolModificado.nombre = this.nombreInput.Text;
        }

        // Habilitar
        private void habilitadoRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.rolModificado.habilitado = true;
        }

        // Deshabilitar
        private void deshabilitadoRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.rolModificado.habilitado = false;
        }

    }
}
