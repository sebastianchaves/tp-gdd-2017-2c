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
        // Atributos
        private Empresa nuevaEmpresa;
        private EmpresaDAO empresaDao;
        private Util utils;

        // Constructores
        public AltaEmpresa()
        {
            InitializeComponent();

            this.nuevaEmpresa = new Empresa();
            this.empresaDao = new EmpresaDAO();
            this.utils = new Util();
            this.cargarRubros();
        }

        // Metodos
        private void agregarEmpresa()
        {
            this.nuevaEmpresa.habilitada = true;

            if (this.camposCompletos())
            {
                this.empresaDao.agregarEmpresa(this.nuevaEmpresa);
                MessageBox.Show("Empresa agregada!");
                utils.clearTextBoxes(this);
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
            List<String> rubros = this.empresaDao.findRubrosDisponibles();

            var dataSource = new List<String>();

            foreach (String rubro in rubros)
            {
                dataSource.Add(rubro);
            }

            rubroCombo.DataSource = dataSource;

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
                utils.catchearErrorFormato(ex, cuitTooltip, cuitInput);
            }
        }

        private void tryCargarCuit(String cuit)
        {
            if (this.empresaDao.existeCuit(Int32.Parse(cuit)))
            {
                cuitTooltip.Show("Ya existe ese CUIT.", cuitInput, 1500);
                cuitInput.Clear();
            }
            else
            {
                this.nuevaEmpresa.cuit = Int32.Parse(cuit);
            }
        }

        // Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.nuevaEmpresa.direccion = direccionInput.Text;
        }

        // Rubro
        private void rubroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nuevaEmpresa.rubro = rubroCombo.SelectedItem.ToString();
        }

    }
}
