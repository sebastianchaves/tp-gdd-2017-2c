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
    public partial class AltaSucursal : Form
    {

        private Sucursal nuevaSucursal;
        private SucursalDAO<Sucursal> sucursalDao;
        private Utils utils;

        public AltaSucursal()
        {
            InitializeComponent();

            this.nuevaSucursal = new Sucursal();
            this.sucursalDao = new SucursalDAO<Sucursal>();
        }

        private void agregarSucursal()
        {
            this.nuevaSucursal.activo = true;

            try
            {
                if (this.camposCompletos())
                {
                    this.sucursalDao.agregarSucursal(this.nuevaSucursal);
                    MessageBox.Show("Sucursal agregada!");
                    Utils.clearTextBoxes(this);
                }
                else
                {
                    MessageBox.Show("Complete los campos faltantes.");
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
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.agregarSucursal();
            this.nuevaSucursal = new Sucursal();
            Utils.clearTextBoxes(this);
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cargar Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.nuevaSucursal.nombre = this.nombreInput.Text;
        }

        // Cargar Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.nuevaSucursal.direccion = this.direccionInput.Text;
        }

        // Cargar Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            this.nuevaSucursal.codigoPostal = this.codigoPostalInput.Text;
        }

    }
}
