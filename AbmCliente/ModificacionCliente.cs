using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
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

namespace PagoAgilFrba.AbmCliente
{
    public partial class ModificacionCliente : Form
    {

        // Atributos
        private Util utils;
        private Cliente clienteACargar;
        private Cliente clienteModificado;
        private ClienteDAO clienteDao;

        // Constructores
        public ModificacionCliente()
        {
            InitializeComponent();
            this.utils = new Util();
            this.clienteModificado = new Cliente();
            this.clienteACargar = new Cliente();
            this.clienteDao = new ClienteDAO();
        }

        // Metodos
        private void cargarDatos()
        {
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

            this.calleInput.Text = this.clienteACargar.calle;
            this.clienteModificado.calle = this.clienteACargar.calle;

            this.numeroDomicilioInput.Text = this.clienteACargar.numero.ToString();
            this.clienteModificado.numero = this.clienteACargar.numero;

            this.localidadInput.Text = this.clienteACargar.localidad;
            this.clienteModificado.localidad = this.clienteACargar.localidad;

            this.codigoPostalInput.Text = this.clienteACargar.codigoPostal.ToString();
            this.clienteModificado.codigoPostal = this.clienteACargar.codigoPostal;

            this.pisoInput.Text = this.clienteACargar.piso.ToString();
            this.clienteModificado.piso = this.clienteACargar.piso;

            this.departamentoInput.Text = this.clienteACargar.departamento;
            this.clienteModificado.departamento = this.clienteACargar.departamento;

            this.habilitarDeshabilitar();
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

        public void modificarCliente()
        {
            if (camposCompletos())
            {
                if (this.utils.fechaValida(this.clienteModificado.fechaDeNacimiento))
                {
                    clienteDao.updateCliente(clienteModificado);
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

        public Boolean camposCompletos()
        {
            return (this.nombreInput.Text != "") &&
            (this.apellidoInput.Text != "") &&
            (this.dniInput.Text != "") &&
            (this.mailInput.Text != "") &&
            (this.telefonoInput.Text != "") &&
            (this.calleInput.Text != "") &&
            (this.numeroDomicilioInput.Text != "") &&
            (this.localidadInput.Text != "") &&
            (this.codigoPostalInput.Text != "") &&
            (this.pisoInput.Text != "") &&
            (this.departamentoInput.Text != "");
   
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            utils.iniciarGrids(resultadosGrid);

            using (BusquedaCliente busquedaForm = new BusquedaCliente(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);
            }
        }

        // Boton Seleccionar
        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            var cliente = resultadosGrid.SelectedCells[0].RowIndex;
            this.clienteACargar = new Cliente();
            int dniSeleccionado = Int32.Parse(resultadosGrid.Rows[cliente].Cells[2].Value.ToString());
            this.clienteACargar = this.clienteDao.findCliente("", "", dniSeleccionado).First();
            this.cargarDatos();
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.modificarCliente();
            utils.clearTextBoxes(this);
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

    }
}
