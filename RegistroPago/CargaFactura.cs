using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.RegistroPago
{
    public partial class CargaFactura : Form
    {

        // Atributos
        private Factura nuevaFactura;

        // Constructores
        public CargaFactura()
        {
            InitializeComponent();
            this.nuevaFactura = new Factura();
        }

        // Metodos
        public Factura getNuevaFactura()
        {
            return this.nuevaFactura;
        }

        // Eventos
        // Boton Buscar Cliente
        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaClienteForm = new BusquedaCliente())
            {
                busquedaClienteForm.ShowDialog(this);

                Cliente clienteEncontrado = busquedaClienteForm.getClienteEncontrado();
                this.nuevaFactura.idCliente = clienteEncontrado.id;
                this.clienteInput.Text = clienteEncontrado.nombre;
            }
        }

        // Boton Buscar Empresa
        private void botonBuscarEmpresa_Click(object sender, EventArgs e)
        {
            using (BusquedaEmpresa busquedaEmpresaForm = new BusquedaEmpresa())
            {
                busquedaEmpresaForm.ShowDialog(this);
                nuevaFactura.idEmpresa = busquedaEmpresaForm.getEmpresaEncontrada().id;
            }
        }

        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.nuevaFactura = new Factura();

        }

        // Boton Cancelar
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
