using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
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

namespace PagoAgilFrba.AbmCliente
{
    public partial class ModificacionCliente : Form
    {

        private Cliente clienteACargar;
        private Cliente clienteModificado;
        private ClienteDAO<Cliente> clienteDao;

        public ModificacionCliente()
        {
            InitializeComponent();
            this.clienteModificado = new Cliente();
            this.clienteACargar = new Cliente();
            this.clienteDao = new ClienteDAO<Cliente>();
        }

        // Metodos
        private void cargarDatos()
        {
            this.clienteModificado.id = this.clienteACargar.id;

            this.nombreInput.Text = this.clienteACargar.nombre;
            this.clienteModificado.nombre = this.clienteACargar.nombre;

            this.apellidoInput.Text = this.clienteACargar.apellido;
            this.clienteModificado.apellido = this.clienteACargar.apellido;

            this.dniInput.Text = this.clienteACargar.dni.ToString();
            this.clienteModificado.dni = this.clienteACargar.dni;

            this.mailInput.Text = this.clienteACargar.mail;
            this.clienteModificado.mail = this.clienteACargar.mail;

            this.fechaDeNacimientoInput.Value = this.clienteACargar.fechaDeNacimiento;
            this.clienteModificado.fechaDeNacimiento = this.clienteACargar.fechaDeNacimiento;

            this.telefonoInput.Text = this.clienteACargar.telefono;
            this.clienteModificado.telefono = this.clienteACargar.telefono;

            this.codigoPostalInput.Text = this.clienteACargar.codigoPostal.ToString();
            this.clienteModificado.codigoPostal = this.clienteACargar.codigoPostal;

            this.cargarDireccion();

            this.habilitarDeshabilitar();
        }

        private void cargarDireccion()
        {
            String direccion = this.clienteACargar.direccion;

            String[] partes = direccion.Split(' ');

            String calle = partes[0];
            String numero = partes[1];
            String localidad = partes[2];
            String piso = null;
            String departamento = null;

            if(direccion.Contains("Piso:") || direccion.Contains("Dto:"))
            {
                if (direccion.Contains("Piso:") && !direccion.Contains("Dto:"))
                {
                    String pisoDepartamento = direccion.Substring(direccion.IndexOf("Piso:"));

                    String[] partesPiso = pisoDepartamento.Split(' ');

                    piso = partesPiso[1];
                }
                else if (direccion.Contains("Dto:") && !direccion.Contains("Piso:"))
                {
                    String pisoDepartamento = direccion.Substring(direccion.IndexOf("Dto:"));

                    String[] partesDepartamento = pisoDepartamento.Split(' ');

                    departamento = partesDepartamento[1];
                }
                else if (direccion.Contains("Dto:") && direccion.Contains("Piso:"))
                {
                    String pisoDepartamento = direccion.Substring(direccion.IndexOf("Piso:"));

                    String[] partesPisoDepartamento = pisoDepartamento.Split(' ');

                    piso = partesPisoDepartamento[1];
                    departamento = partesPisoDepartamento[3];
                }

            }

            this.calleInput.Text = calle;

            this.numeroDomicilioInput.Text = numero;
            this.localidadInput.Text = localidad;

            if (departamento != null)
            {
                this.departamentoInput.Text = departamento.ToString();
            }

            if (piso != null)
            {
                this.pisoInput.Text = piso.ToString();
            }
        }

        private void habilitarDeshabilitar()
        {
            this.habilitadoRadioButton.Enabled = true;
            this.deshabilitadoRadioButton.Enabled = true;

            if (this.clienteACargar.habilitado)
            {
                this.habilitadoRadioButton.PerformClick();
                this.clienteModificado.habilitado = true;
            }
            else
            {
                this.deshabilitadoRadioButton.PerformClick();
                this.clienteModificado.habilitado = false;
            }
        }

        private void modificarCliente()
        {
            try
            {
                if (camposCompletos())
                {
                    if (Utils.fechaValida(this.clienteModificado.fechaDeNacimiento))
                    {
                        this.armarDireccion();
                        this.clienteDao.updateCliente(clienteModificado);
                        Utils.clearTextBoxes(this);
                        this.deshabilitarCampos();
                        this.botonActualizar.Enabled = false;
                        MessageBox.Show("Datos actualizados!");
                    }
                    else
                    {
                        MessageBox.Show("Fecha fuera de rango.");
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya existe ese mail.");
            }

        }

        private Boolean camposCompletos()
        {
            return (this.nombreInput.Text != "") &&
            (this.apellidoInput.Text != "") &&
            (this.dniInput.Text != "") &&
            (this.mailInput.Text != "") &&
            (this.telefonoInput.Text != "") &&
            (this.calleInput.Text != "") &&
            (this.numeroDomicilioInput.Text != "") &&
            (this.localidadInput.Text != "") &&
            (this.codigoPostalInput.Text != "");
        }

        private void armarDireccion()
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

            this.clienteModificado.direccion = direccion;
        }

        private void habilitarCampos()
        {
            this.nombreInput.Enabled = true;
            this.apellidoInput.Enabled = true;
            this.dniInput.Enabled = true;
            this.mailInput.Enabled = true;
            this.fechaDeNacimientoInput.Enabled = true;
            this.telefonoInput.Enabled = true;
            this.calleInput.Enabled = true;
            this.numeroDomicilioInput.Enabled = true;
            this.localidadInput.Enabled = true;
            this.codigoPostalInput.Enabled = true;
            this.pisoInput.Enabled = true;
            this.departamentoInput.Enabled = true;
        }

        private void deshabilitarCampos()
        {
            this.nombreInput.Enabled = false;
            this.apellidoInput.Enabled = false;
            this.dniInput.Enabled = false;
            this.mailInput.Enabled = false;
            this.fechaDeNacimientoInput.Enabled = false;
            this.telefonoInput.Enabled = false;
            this.calleInput.Enabled = false;
            this.numeroDomicilioInput.Enabled = false;
            this.localidadInput.Enabled = false;
            this.codigoPostalInput.Enabled = false;
            this.pisoInput.Enabled = false;
            this.departamentoInput.Enabled = false;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaForm = new BusquedaCliente())
            {
                busquedaForm.ShowDialog(this);
                this.clienteACargar = busquedaForm.getClienteEncontrado();

                if (this.clienteACargar != null && this.clienteACargar.id != 0)
                {
                    this.botonActualizar.Enabled = true;
                    this.cargarDatos();
                    this.habilitarCampos();
                }

            }
        }

        // Boton Aceptar
        private void botonActualizar_Click(object sender, EventArgs e)
        {
            this.modificarCliente();
            this.clienteModificado = new Cliente();
            this.clienteACargar = new Cliente();
        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Habilitar
        private void habilitadoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.clienteModificado.habilitado = true;
        }

        // Deshabilitar
        private void deshabilitadoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.clienteModificado.habilitado = false;
        }

        // Cargando datos nuevos
        // Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.clienteModificado.nombre = this.nombreInput.Text;
        }

        // Apellido
        private void apellidoInput_Leave(object sender, EventArgs e)
        {
            this.clienteModificado.apellido = this.apellidoInput.Text;
        }

        // DNI
        private void dniInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.clienteModificado.dni = Int32.Parse(this.dniInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, dniTooltip, dniInput);
            }
        
        }

        // Mail
        private void mailInput_Leave(object sender, EventArgs e)
        {
            this.clienteModificado.mail = this.mailInput.Text;
        }

        // Fecha Nacimiento
        private void fechaDeNacimientoInput_Leave(object sender, EventArgs e)
        {
            if (fechaDeNacimientoInput.Value.Date <= Utils.appDate.Date)
            {
                this.clienteModificado.fechaDeNacimiento = this.fechaDeNacimientoInput.Value;
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
            this.clienteModificado.telefono = this.telefonoInput.Text;
        }

    }
}
