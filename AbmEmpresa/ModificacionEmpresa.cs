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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ModificacionEmpresa : Form
    {

        // Atributos
        private Util utils;
        private Empresa empresaModificada;
        private Empresa empresaACargar;
        private EmpresaDAO empresaDao;

        // Constructores
        public ModificacionEmpresa()
        {
            InitializeComponent();

            this.utils = new Util();
            this.empresaDao = new EmpresaDAO();
            this.empresaModificada = new Empresa();
        }

        // Metodos
        private void cargarDatos()
        {
            this.nombreInput.Text = this.empresaACargar.nombre;
            this.empresaModificada.nombre = this.empresaACargar.nombre;

            this.cuitInput.Text = this.empresaACargar.cuit.ToString();
            this.empresaModificada.cuit = this.empresaACargar.cuit;

            this.direccionInput.Text = this.empresaACargar.direccion;
            this.empresaModificada.direccion = this.empresaACargar.direccion;

            this.rubroCombo.SelectedIndex = this.rubroCombo.FindString(this.empresaACargar.rubro);
            this.empresaModificada.rubro = this.empresaACargar.rubro;

            this.habilitarDeshabilitar();
        }

        private void habilitarDeshabilitar()
        {

            this.habilitadaRadioButton.Enabled = true;
            this.deshabilitadaRadioButton.Enabled = true;

            if (this.empresaACargar.habilitada)
            {
                this.habilitadaRadioButton.PerformClick();
                this.empresaModificada.habilitada = true;
            }
            else
            {
                this.deshabilitadaRadioButton.PerformClick();
                this.empresaModificada.habilitada = false;
            }
        }

        private void updateEmpresa()
        {
            if (this.camposCompletos())
            {
                this.empresaDao.updateEmpresa(this.empresaModificada);
                MessageBox.Show("Datos actualizados!");
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
        }

        private Boolean camposCompletos()
        {
            return this.nombreInput.Text != "" &&
                this.cuitInput.Text != "" &&
                this.direccionInput.Text != "";
        }

        private void cargarRubros()
        {
            List<String> rubros = this.empresaDao.findRubrosDisponibles();

            var dataSource = new List<String>();

            foreach (String rubro in rubros)
            {
                dataSource.Add(rubro);
            }

            this.rubroCombo.DataSource = dataSource;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {    
            utils.iniciarGrids(resultadosGrid);

            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);
                this.botonSeleccionar.Enabled = true;
            }
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.updateEmpresa();
            utils.clearTextBoxes(this);
            this.empresaModificada = new Empresa();
            this.empresaACargar = new Empresa();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton Seleccionar
        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            var empresaIndex = resultadosGrid.SelectedCells[0].RowIndex;
            this.empresaACargar = new Empresa();
            int cuitSeleccionado = Int32.Parse(resultadosGrid.Rows[empresaIndex].Cells[1].Value.ToString());
            this.empresaACargar = this.empresaDao.findEmpresa("", cuitSeleccionado, "").ElementAt(empresaIndex);
            this.cargarRubros();
            this.cargarDatos();
        }

        // Habilitar
        private void habilitadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.empresaModificada.habilitada = true;
        }

        // Deshabilitar
        private void deshabilitadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.empresaModificada.habilitada = false;
        }

    }
}
