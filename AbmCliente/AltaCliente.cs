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
        private ClienteDAO clienteDAO = new ClienteDAO();
        private Cliente nuevoCliente = new Cliente();
        private Util utils = new Util();

        // Constructores
        public AltaCliente()
        {
            InitializeComponent();
        }

        // Metodos
        private void agregarCliente()
        {

            nuevoCliente.habilitado = true;

            if (camposCompletos())
            {
                if (utils.fechaValida(nuevoCliente.fechaDeNacimiento))
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
            utils.clearTextBoxes(this);
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
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
                utils.catchearErrorFormato(ex, dniTooltip, dniInput);
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
            if (fechaDeNacimientoInput.Value.Date <= utils.appDate.Date)
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

        // Domicilio
        // Calle
        private void calleInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.calle = calleInput.Text;
        }

        // Numero
        private void numeroDomicilioInput_Leave(object sender, EventArgs e)
        {
            try
            {
                nuevoCliente.numero = Int32.Parse(numeroDomicilioInput.Text);
            }
            catch (Exception ex)
            {
                utils.catchearErrorFormato(ex, numeroDomicilioTooltip, numeroDomicilioInput);
            }
        }

        // Localidad
        private void localidadInput_Leave(object sender, EventArgs e)
        {
            nuevoCliente.localidad = localidadInput.Text;
        }

        // Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            try
            {
                nuevoCliente.codigoPostal = Int32.Parse(codigoPostalInput.Text);
            }
            catch (Exception ex)
            {
                utils.catchearErrorFormato(ex, codigoPostalTooltip, codigoPostalInput);
            }
        }

        // Piso
        private void pisoInput_Leave(object sender, EventArgs e)
        {
            try
            {
                if (pisoInput.Text == "")
                {
                    nuevoCliente.piso = 0;
                }
                else
                {
                    nuevoCliente.piso = Int32.Parse(pisoInput.Text);
                }
            }
            catch (Exception ex)
            {
                utils.catchearErrorFormato(ex, pisoDomicilioTooltip, pisoInput);
            }
        }

        // Departamento
        private void departamentoInput_Leave(object sender, EventArgs e)
        {

            if (departamentoInput.Text == "")
            {
                nuevoCliente.departamento = null;
            }
            else
            {
                nuevoCliente.departamento = departamentoInput.Text;
            }

        }

    }
}
