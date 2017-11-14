using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{
    public partial class AltaCliente : Form
    {

        private ClienteDAO<Cliente> clienteDAO;
        private Cliente nuevoCliente;

        public AltaCliente()
        {
            InitializeComponent();
            this.nuevoCliente = new Cliente();
            this.clienteDAO = new ClienteDAO<Cliente>();
        }

        private void agregarCliente()
        {
            try
            {
                this.nuevoCliente.habilitado = true;

                if (camposCompletos())
                {
                    if (Utils.fechaValida(nuevoCliente.fechaDeNacimiento))
                    {
                        this.cargarDireccion();
                        clienteDAO.agregarCliente(nuevoCliente);
                        Utils.clearTextBoxes(this);
                        this.nuevoCliente = new Cliente();
                        MessageBox.Show("Cliente agregado!");
                    }
                    else
                    {
                        MessageBox.Show("Fecha incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos faltantes.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya existe ese mail.");
            }
        }

        private Boolean camposCompletos()
        {
            return (nombreInput.Text != "") &&
                   (apellidoInput.Text != "") &&
                   (dniInput.Text != "") &&
                   (telefonoInput.Text != "") &&
                   (mailInput.Text != "") &&
                   (calleInput.Text != "") &&
                   (numeroDomicilioInput.Text != "") &&
                   (localidadInput.Text != "") &&
                   (codigoPostalInput.Text != "");
        }

        private void cargarDireccion()
        {
            String direccion = "";

            direccion += this.calleInput.Text + " " + this.numeroDomicilioInput.Text
                            + " " + this.localidadInput.Text;

            if (this.pisoInput.Text != "")
            {
                direccion += " Piso: " + this.pisoInput.Text;
            }

            if (this.departamentoInput.Text != "")
            {
                direccion += " Dto: " + this.departamentoInput.Text;
            }

            this.nuevoCliente.direccion = direccion;
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.agregarCliente();
        }

        // Boton Cancelar
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga de cliente
        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.nombre = nombreInput.Text;
        }

        // Apellido
        private void apellidoInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.apellido = apellidoInput.Text;
        }

        // DNI
        private void dniInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.nuevoCliente.dni = Int32.Parse(dniInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, dniTooltip, dniInput);
            }
        }

        // Fecha de Nacimiento
        private void fechaDeNacimientoInput_Leave(object sender, EventArgs e)
        {
            if (fechaDeNacimientoInput.Value.Date <= Utils.appDate.Date)
            {
                nuevoCliente.fechaDeNacimiento = fechaDeNacimientoInput.Value;
            }
            else
            {
                fechaNacimientoTooltip.Show("Fecha invalida", fechaDeNacimientoInput, 1500);
                fechaDeNacimientoInput.ResetText();
            }
        }

        // Telefono
        private void telefonoInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.telefono = telefonoInput.Text;
        }

        // Mail
        private void mailInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.mail = mailInput.Text;
        }

        // Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            try
            {
                nuevoCliente.codigoPostal = codigoPostalInput.Text;
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, codigoPostalTooltip, codigoPostalInput);
            }
        }

    }
}
