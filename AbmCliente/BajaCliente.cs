using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class BajaCliente : Form
    {

        private ClienteDAO<Cliente> clienteDao;
        private Cliente clienteSeleccionado;

        public BajaCliente()
        {
            InitializeComponent();

            this.clienteDao = new ClienteDAO<Cliente>();
        }

        private void cargarDatos()
        {
            this.nombreInput.Text = this.clienteSeleccionado.nombre;
            this.apellidoInput.Text = this.clienteSeleccionado.apellido;
            this.dniInput.Text = this.clienteSeleccionado.dni.ToString();
            this.mailInput.Text = this.clienteSeleccionado.mail;
            this.fechaNacimientoInput.Value = this.clienteSeleccionado.fechaDeNacimiento;
            this.telefonoInput.Text = this.clienteSeleccionado.telefono;
            this.direccionInput.Text = this.clienteSeleccionado.direccion;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaForm = new BusquedaCliente())
            {
                busquedaForm.ShowDialog(this);
                this.clienteSeleccionado = busquedaForm.getClienteEncontrado();
                this.botonDeshabilitar.Enabled = true;
                this.cargarDatos();
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boton Deshabilitar
        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {
            if (!this.clienteSeleccionado.habilitado)
            {
                MessageBox.Show("Este cliente ya se encuentra deshabilitado...");
            }
            else
            {
                this.clienteSeleccionado.habilitado = false;
                this.clienteDao.updateCliente(this.clienteSeleccionado);
                this.clienteSeleccionado = new Cliente();
                MessageBox.Show("Cliente deshabilitado con exito!");
            }
        }



    }
}
