using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmCliente
{

    public partial class AltaCliente : Form
    {

        // Variables
        private ClienteDAO<Cliente> clienteDAO;
        private Cliente nuevoCliente;

        // Constructores
        public AltaCliente()
        {
            InitializeComponent();
            this.nuevoCliente = new Cliente();
            this.clienteDAO = new ClienteDAO<Cliente>();
        }

        // Metodos
        private void agregarCliente()
        {

            nuevoCliente.habilitado = true;

            if (camposCompletos())
            {
                if (Utils.fechaValida(nuevoCliente.fechaDeNacimiento))
                {
                    clienteDAO.agregarCliente(nuevoCliente);
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

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            agregarCliente();
            Utils.clearTextBoxes(this);
            this.nuevoCliente = new Cliente();
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
                tryCargarDni(dniInput.Text);
            }

            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, dniTooltip, dniInput);
            }
        }

        private void tryCargarDni(String dni)
        {
            if (clienteDAO.existeDni(Int32.Parse(dni)))
            {
                dniTooltip.Show("Ya existe el DNI.", dniInput, 1500);
                dniInput.Clear();
            }
            else
            {
                nuevoCliente.dni = Int32.Parse(dni);
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
            if (clienteDAO.existeMail(mailInput.Text))
            {
                mailTooltip.Show("Ya existe ese mail.", mailInput, 1500);
                mailInput.Clear();
            }
            else
            {
                nuevoCliente.mail = mailInput.Text;
            }
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
