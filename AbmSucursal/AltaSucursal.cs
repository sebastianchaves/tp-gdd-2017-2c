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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class AltaSucursal : Form
    {

        // Atributos
        private Sucursal nuevaSucursal;
        private SucursalDAO sucursalDao;
        private Util utils;

        // Constructores
        public AltaSucursal()
        {
            InitializeComponent();

            this.nuevaSucursal = new Sucursal();
            this.sucursalDao = new SucursalDAO();
            this.utils = new Util();
        }

        // Metodos
        private void agregarSucursal()
        {
            this.nuevaSucursal.habilitada = true;

            if (this.camposCompletos())
            {
                this.sucursalDao.agregarSucursal(this.nuevaSucursal);
                MessageBox.Show("Sucursal agregada!");
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
                this.direccionInput.Text != "" &&
                this.codigoPostalInput.Text != "";
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.agregarSucursal();
            this.nuevaSucursal = new Sucursal();
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
            try
            {
                this.tryCargarCodigoPostal(this.codigoPostalInput.Text);
            }
            catch (Exception ex)
            {
                this.utils.catchearErrorFormato(ex, this.codigoPostalTooltip, this.codigoPostalInput);
            }
        }

        private void tryCargarCodigoPostal(String codigoPostal)
        {
            if (this.sucursalDao.existeCodigoPostal(Int32.Parse(codigoPostal)))
            {
                codigoPostalTooltip.Show("Ya existe una sucursal con ese Codigo Postal.", codigoPostalInput, 1500);
                codigoPostalInput.Clear();
            }
            else
            {
                this.nuevaSucursal.codigoPostal = Int32.Parse(codigoPostal);
            }
        }

    }
}
