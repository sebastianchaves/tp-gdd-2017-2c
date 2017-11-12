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
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Rendiciones;
using PagoAgilFrba.Devoluciones;

namespace PagoAgilFrba
{
    public partial class FrmPrincipal : Form
    {

        public static Usuario usuarioLogeado;
        private List<Rol> rolesUsuario;

        private RolDAO<Rol> rolDao;
        private Rol rolSeleccionado;

        private FuncionalidadDAO<Funcionalidad> funcionalidadDAO;
        private List<Funcionalidad> funcionalidadesEncontradas;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            FrmPrincipal.usuarioLogeado = usuario;
            this.rolDao = new RolDAO<Rol>();
            this.funcionalidadDAO = new FuncionalidadDAO<Funcionalidad>();
            logeoUsuario();
        }

        private void logeoUsuario()
        {

            this.rolesUsuario = this.rolDao.obtenerRolesPorUsuario(FrmPrincipal.usuarioLogeado.nombre);

            if (this.rolesUsuario.Count == 1)
            {
                this.rolSeleccionado = this.rolesUsuario.ElementAt(0);
            }
            else if (this.rolesUsuario.Count > 1)
            {
                using (FrmSeleccionRol seleccionRol = new FrmSeleccionRol(this.rolesUsuario))
                {
                    seleccionRol.ShowDialog();
                    this.rolSeleccionado = seleccionRol.getRolSeleccionado();
                }
            }

            this.funcionalidadesEncontradas = this.funcionalidadDAO.obtenerFuncionalidadesPorRol(this.rolSeleccionado.nombre);
            this.habilitarFuncionalidades();
        }

        private void habilitarFuncionalidades()
        {
            for (int i = 0; i < this.funcionalidadesEncontradas.Count; i++)
            {
                switch (this.funcionalidadesEncontradas.ElementAt(i).nombre)
                {
                    case "abm_rol":
                        this.abmRolTooltip.Enabled = true;
                        break;

                    case "abm_cliente":
                        this.abmClienteTooltip.Enabled = true;
                        break;

                    case "abm_empresa":
                        this.abmEmpresaTooltip.Enabled = true;
                        break;

                    case "abm_sucursal":
                        this.abmSucursalTooltip.Enabled = true;
                        break;

                    case "abm_factura":
                        this.aFacturaTooltip.Enabled = true;
                        this.bFacturaTooltip.Enabled = true;
                        this.mFacturaTooltip.Enabled = true;
                        break;

                    case "abm_pago":
                        this.pagoFacturaTooltip.Enabled = true;
                        break;

                    case "abm_rendicion":
                        this.rendicionTooltip.Enabled = true;
                        break;

                    case "abm_estadisticas":
                        this.estadisticasTooltip.Enabled = true;
                        break;

                    case "abm_devolucion_factura":
                        this.devolucionFacturaTooltip.Enabled = true;
                        break;

                    case "abm_devolucion_rendicion":
                        this.devolucionRendicionTooltip.Enabled = true;
                        break;

                    default:
                        break;
                }
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
        private void bFacturaTooltip_Click(object sender, EventArgs e)
        {
            new BajaFactura().ShowDialog();
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

        // Sucursal
        private void altaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AltaSucursal().ShowDialog();
        }
        private void modificaciónSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModificacionSucursal().ShowDialog();
        }

        // Rendiciones
        private void rendicionTooltip_Click(object sender, EventArgs e)
        {
            new FrmRendicion().ShowDialog();
        }

        // Estadisticas
        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListadoEstadisticoForm().ShowDialog();
        }

        // Devolucion Factura
        private void devolucionFacturaTooltip_Click(object sender, EventArgs e)
        {
            new DevolucionFacturaForm().ShowDialog();
        }

        // Devolucion Rendicion
        private void devolucionRendicionTooltip_Click(object sender, EventArgs e)
        {
            new DevolucionRendicionForm().ShowDialog();
        }

    }
}
