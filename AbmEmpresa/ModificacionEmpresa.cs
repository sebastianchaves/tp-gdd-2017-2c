using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
using System;
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
            this.empresaModificada.id = this.empresaACargar.id;

            this.nombreInput.Text = this.empresaACargar.nombre;
            this.empresaModificada.nombre = this.empresaACargar.nombre;

            this.cuitInput.Text = this.empresaACargar.cuit.ToString();
            this.empresaModificada.cuit = this.empresaACargar.cuit;

            this.direccionInput.Text = this.empresaACargar.direccion;
            this.empresaModificada.direccion = this.empresaACargar.direccion;

            this.diaDeRendicionText.Text = this.empresaACargar.diaDeRendicion.ToString();
            this.empresaModificada.diaDeRendicion = this.empresaACargar.diaDeRendicion;

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

            if (!Validaciones.validarCuit(this.cuitInput.Text))
            {
                MessageBox.Show("Formato de CUIT invalido. Por favor ingrese un CUIT valido con el formato: XX-XXXXXXXX-X");
                return;
            }

            if (this.camposCompletos())
            {
                if (!Validaciones.campoNumerico(diaDeRendicionText.Text) || Int32.Parse(diaDeRendicionText.Text) < 1
                    || Int32.Parse(diaDeRendicionText.Text) > 28)
                {
                    MessageBox.Show("El dia de rendicion debe ser entre 1 y 28 inclusive");
                    return;
                }

                if (!this.empresaModificada.activo && this.empresaACargar.activo)
                {
                    if (!this.empresaDao.puedeDeshabilitar(this.empresaModificada))
                    {
                        MessageBox.Show("Esta empresa posee facturas cobradas pendientes de rendicion");
                        return;
                    }

                    this.empresaDao.updateEmpresa(this.empresaModificada);
                    MessageBox.Show("Datos actualizados!");
                    volverADefault();
                }
                else
                {
                    this.empresaDao.updateEmpresa(this.empresaModificada);
                    MessageBox.Show("Datos actualizados!");
                    volverADefault();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios.");
            }
        }

        private void volverADefault()
        {
            Utils.clearTextBoxes(this);
            this.empresaModificada = new Empresa();
            this.empresaACargar = new Empresa();
            this.deshabilitarCampos();
            this.botonActualizar.Enabled = false;
        }

        private Boolean camposCompletos()
        {
            return this.nombreInput.Text != "" &&
                this.cuitInput.Text != "" &&
                this.direccionInput.Text != "" &&
                this.empresaACargar.diaDeRendicion > 0 && this.empresaACargar.diaDeRendicion < 29;
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

        private void habilitarCampos()
        {
            this.nombreInput.Enabled = true;
            this.cuitInput.Enabled = true;
            this.direccionInput.Enabled = true;
            this.rubroCombo.Enabled = true;
            this.diaDeRendicionText.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.nombreInput.Enabled = false;
            this.cuitInput.Enabled = false;
            this.direccionInput.Enabled = false;
            this.rubroCombo.Enabled = false;
            this.diaDeRendicionText.Enabled = false;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {    
            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa())
            {
                busquedaForm.ShowDialog(this);
                this.empresaACargar = busquedaForm.getEmpresaEncontrada();

                if (this.empresaACargar != null)
                {
                    this.cargarRubros();
                    this.cargarDatos();
                    this.botonActualizar.Enabled = true;
                    this.habilitarCampos();
                }

            }
        }

        // Boton Actualizar
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.updateEmpresa();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error en la modificacion. Asegurese que el CUIT es unico");
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int a;
            bool result = Int32.TryParse(this.diaDeRendicionText.Text, out a);
            if (result)
            {
                this.empresaModificada.diaDeRendicion = a;
            }
            else
            {
                this.empresaModificada.diaDeRendicion = -1;
            }
        }

        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.empresaModificada.direccion = this.direccionInput.Text;
        }

        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.empresaModificada.nombre = this.nombreInput.Text;
        }

        private void cuitInput_Leave(object sender, EventArgs e)
        {
            this.empresaModificada.cuit = this.cuitInput.Text;
        }

        private void rubroCombo_Leave(object sender, EventArgs e)
        {
            foreach (Rubro rubro in this.rubrosEncontrados)
            {
                if (rubro.indexCombo == this.rubroCombo.SelectedIndex)
                {
                    this.empresaModificada.idRubro = rubro.id;
                    break;
                }
            }
        }

    }
}
