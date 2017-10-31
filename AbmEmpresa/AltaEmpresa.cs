using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections;
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
    public partial class AltaEmpresa : Form
    {

        private Empresa nuevaEmpresa;
        private EmpresaDAO<Empresa> empresaDao;
        private RubroDAO<Rubro> rubroDao;
        private List<Rubro> rubrosEncontrados;

        public AltaEmpresa()
        {
            InitializeComponent();

            this.nuevaEmpresa = new Empresa();
            this.empresaDao = new EmpresaDAO<Empresa>();
            this.rubroDao = new RubroDAO<Rubro>();
            this.cargarRubros();
        }

        private void agregarEmpresa()
        {
            this.nuevaEmpresa.activo = true;

            if (this.camposCompletos())
            {
                this.empresaDao.agregarEmpresa(this.nuevaEmpresa);
                MessageBox.Show("Empresa agregada!");
                Utils.clearTextBoxes(this);
            }
            else
            {
                MessageBox.Show("Complete los campos faltantes.");
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

            rubroCombo.DataSource = dataSource;
        }

        private Rubro rubroByIndex(int index)
        {
            return this.rubrosEncontrados.Find(rubro => rubro.indexCombo.Equals(index));
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            agregarEmpresa();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga de empresa
        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.nuevaEmpresa.nombre = nombreInput.Text;
        }

        // Cuit
        private void cuitInput_Leave_1(object sender, EventArgs e)
        {
            try
            {
                tryCargarCuit(cuitInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, cuitTooltip, cuitInput);
            }
        }

        private void tryCargarCuit(String cuit)
        {
            this.nuevaEmpresa.cuit = cuitInput.Text;
        }

        // Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.nuevaEmpresa.direccion = direccionInput.Text;
        }

        // Rubro
        private void rubroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nuevaEmpresa.idRubro = this.rubroByIndex(this.rubroCombo.SelectedIndex).id;
        }

    }
}
