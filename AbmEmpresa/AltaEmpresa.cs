using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                this.nuevaEmpresa.activo = true;

                if (Validaciones.validarCuit(this.cuitInput.Text))
                {
                    if (this.camposCompletos())
                    {
                        this.empresaDao.agregarEmpresa(this.nuevaEmpresa);
                        MessageBox.Show("Empresa agregada!");
                        Utils.clearTextBoxes(this);
                        this.nuevaEmpresa = new Empresa();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los campos faltantes.");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de CUIT invalido. Por favor ingrese un CUIT valido con el formato: XX-XXXXXXXX-X");
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Error en la carga de la empresa.");
            }
        }

        private Boolean camposCompletos()
        {
            return this.nombreInput.Text != "" &&
                this.cuitInput.Text != "" &&
                this.direccionInput.Text != "" &&
                this.diaDeRendicion.Text != "" &&
                this.nuevaEmpresa.diaDeRendicion > 0 && this.nuevaEmpresa.diaDeRendicion < 29;
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
            this.nuevaEmpresa = new Empresa();
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

        private void diaDeRendicion_Leave(object sender, EventArgs e)
        {
            int a;
            bool result = Int32.TryParse(this.diaDeRendicion.Text, out a);
            if (result)
            {
                this.nuevaEmpresa.diaDeRendicion = a;
            }
            else
            {
                this.nuevaEmpresa.diaDeRendicion = -1;
            }
        }

    }
}
