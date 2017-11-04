using PagoAgilFrba.AbmCliente;
using PagoAgilFrba.AbmEmpresa;
using PagoAgilFrba.AbmFactura;
using PagoAgilFrba.AbmRol;
using PagoAgilFrba.AbmSucursal;
using PagoAgilFrba.RegistroPago;
using PagoAgilFrba.ListadoEstadistico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Load
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            using (FrmLogin login = new FrmLogin())
            {
                login.ShowDialog();
            }

        }

        // Archivo
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cliente
        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaCliente().ShowDialog();
        }
        private void modificaciónClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionCliente().ShowDialog();
        }
        private void bajaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaCliente().ShowDialog();
        }

        // Boton Salir
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Empresa
        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaEmpresa().ShowDialog();
        }
        private void modificaciónEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionEmpresa().ShowDialog();
        }
        private void bajaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaEmpresa().ShowDialog();
        }

        // Factura
        private void altaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaFactura().ShowDialog();
        }

        private void modificaciónFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionFactura().ShowDialog();
        }

        private void pagoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroPagoForm().ShowDialog();
        }

        // Rol
        private void altaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaRol().ShowDialog();
        }

        private void modificaciónRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionRol().ShowDialog();
        }

        private void bajaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaRol().ShowDialog();
        }

        // Sucursal
        private void altaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaSucursal().ShowDialog();
        }

        private void modificaciónSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionSucursal().ShowDialog();
        }

        private void bajaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BajaSucursal().ShowDialog();
        }

        // Estadisticas
        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoEstadisticoForm().ShowDialog();
        }



    }
}
