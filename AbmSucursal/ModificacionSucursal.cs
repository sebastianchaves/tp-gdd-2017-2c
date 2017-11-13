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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ModificacionSucursal : Form
    {

        private Sucursal sucursalACargar;
        private Sucursal sucursalModificada;
        private SucursalDAO<Sucursal> sucursalDao;

        public ModificacionSucursal()
        {
            InitializeComponent();

            this.sucursalDao = new SucursalDAO<Sucursal>();
            this.sucursalModificada = new Sucursal();
            this.sucursalACargar = new Sucursal();
        }

        private void cargarDatos()
        {
            this.sucursalModificada.id = this.sucursalACargar.id;

            this.nombreInput.Text = this.sucursalACargar.nombre;
            this.sucursalModificada.nombre = this.sucursalACargar.nombre;

            this.direccionInput.Text = this.sucursalACargar.direccion;
            this.sucursalModificada.direccion = this.sucursalACargar.direccion;

            this.codigoPostalInput.Text = this.sucursalACargar.codigoPostal;
            this.sucursalModificada.codigoPostal = this.sucursalACargar.codigoPostal;

            this.habilitarDeshabilitar();
        }

        private void habilitarDeshabilitar()
        {
            this.habilitadaRadioButtion.Enabled = true;
            this.deshabilitadaRadioButton.Enabled = true;

            if (this.sucursalACargar.activo)
            {
                this.habilitadaRadioButtion.PerformClick();
                this.sucursalModificada.activo = true;
            }
            else
            {
                this.deshabilitadaRadioButton.PerformClick();
                this.sucursalModificada.activo = false;
            }
        }

        private void habilitarCampos()
        {
            this.nombreInput.Enabled = true;
            this.direccionInput.Enabled = true;
            this.codigoPostalInput.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.nombreInput.Enabled = false;
            this.direccionInput.Enabled = false;
            this.codigoPostalInput.Enabled = false;
        }

        private void modificarSucursal()
        {
            try
            {
                if (camposCompletos())
                {
                    this.sucursalDao.updateSucursal(this.sucursalModificada);
                    Utils.clearTextBoxes(this);
                    this.deshabilitarCampos();
                    this.botonActualizar.Enabled = false;
                    MessageBox.Show("Datos actualizados!");
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya existe sucursal con ese codigo postal.");
            }
        }

        private Boolean camposCompletos()
        {
            return this.nombreInput.Text != "" &&
                this.direccionInput.Text != "" &&
                this.codigoPostalInput.Text != "";
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaSucursal busquedaForm = new BusquedaSucursal())
            {
                busquedaForm.ShowDialog(this);
                this.sucursalACargar = busquedaForm.getSucursalEncontrada();

                if (this.sucursalACargar != null)
                {
                    this.botonActualizar.Enabled = true;
                    this.cargarDatos();
                    this.habilitarCampos();
                }

            }
        }

        // Boton Actualizar
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            this.modificarSucursal();
            this.sucursalModificada = new Sucursal();
            this.sucursalACargar = new Sucursal();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargando Datos
        // Habilitar
        private void habilitadaRadioButtion_CheckedChanged(object sender, EventArgs e)
        {
            this.sucursalModificada.activo = true;
        }

        // Deshabilitar
        private void deshabilitadaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.sucursalModificada.activo = false;
        }

        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.sucursalModificada.nombre = this.nombreInput.Text;
        }

        // Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.sucursalModificada.direccion = this.direccionInput.Text;
        }

        // Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            this.sucursalModificada.codigoPostal = this.codigoPostalInput.Text;
        }

    }
}
