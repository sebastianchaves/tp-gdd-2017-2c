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

        private Empresa empresaModificada;
        private Empresa empresaACargar;
        private EmpresaDAO<Empresa> empresaDao;
        private RubroDAO<Rubro> rubroDao;
        private List<Rubro> rubrosEncontrados;

        public ModificacionEmpresa()
        {
            InitializeComponent();
            this.empresaDao = new EmpresaDAO<Empresa>();
            this.rubroDao = new RubroDAO<Rubro>();
            this.empresaModificada = new Empresa();
        }

        private void cargarDatos()
        {
            this.nombreInput.Text = this.empresaACargar.nombre;
            this.empresaModificada.nombre = this.empresaACargar.nombre;

            this.cuitInput.Text = this.empresaACargar.cuit.ToString();
            this.empresaModificada.cuit = this.empresaACargar.cuit;

            this.direccionInput.Text = this.empresaACargar.direccion;
            this.empresaModificada.direccion = this.empresaACargar.direccion;

            this.rubroCombo.SelectedIndex = this.rubroCombo.FindString(rubroPorId().nombre);
            this.empresaModificada.idRubro = this.rubrosEncontrados.ElementAt(this.rubroCombo.SelectedIndex).id;

            this.habilitarDeshabilitar();
        }

        private Rubro rubroPorId()
        {
            return this.rubrosEncontrados.Find(rubro => rubro.id.Equals(this.empresaACargar.idRubro));
        }

        private Rubro rubroPorNombre()
        {
            return this.rubrosEncontrados.Find(rubro => rubro.id.Equals(this.empresaACargar.nombre));
        }

        private void habilitarDeshabilitar()
        {

            this.habilitadaRadioButton.Enabled = true;
            this.deshabilitadaRadioButton.Enabled = true;

            if (this.empresaACargar.activo)
            {
                this.habilitadaRadioButton.PerformClick();
                this.empresaModificada.activo = true;
            }
            else
            {
                this.deshabilitadaRadioButton.PerformClick();
                this.empresaModificada.activo = false;
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
            this.rubrosEncontrados = this.rubroDao.findRubros();

            var dataSource = new List<String>();

            for (int i = 0; i < this.rubrosEncontrados.Count; i++)
            {
                this.rubrosEncontrados.ElementAt(i).indexCombo = i;
                dataSource.Add(this.rubrosEncontrados.ElementAt(i).nombre);
            }

            this.rubroCombo.DataSource = dataSource;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {    
            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa())
            {
                busquedaForm.ShowDialog(this);
                this.botonActualizar.Enabled = true;
                this.empresaACargar = busquedaForm.getEmpresaEncontrada();
            }
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.updateEmpresa();
            Utils.clearTextBoxes(this);
            this.empresaModificada = new Empresa();
            this.empresaACargar = new Empresa();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Habilitar
        private void habilitadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.empresaModificada.activo = true;
        }

        // Deshabilitar
        private void deshabilitadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.empresaModificada.activo = false;
        }

    }
}
