using PagoAgilFrba.Model;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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

namespace PagoAgilFrba.Busquedas
{
    partial class ResultadosBusqueda : Form
    {

        // Atributos
        private Cliente clienteSeleccionado;
        private List<Cliente> clientesEncontrados;
        private ClienteDAO<Cliente> clienteDao;

        private Rol rolSeleccionado;
        private List<Rol> rolesEncontrados;
        private RolDAO<Rol> rolDao;

        private Empresa empresaSeleccionada;
        private List<Empresa> empresasEncontradas;
        private EmpresaDAO<Empresa> empresaDao;

        private Sucursal sucursalSeleccionada;
        private List<Sucursal> sucursalesEncontradas;
        private SucursalDAO<Sucursal> sucursalDao;

        private Factura facturaSeleccionada;
        private List<Factura> facturasEncontradas;
        private FacturaDAO<Factura> facturaDao;

        private Rendicion rendicionSeleccionada;
        private List<Rendicion> rendicionesEncontradas;
        private RendicionDAO<Rendicion> rendicionDao;

        // Constructores
        public ResultadosBusqueda(Rol rol)
        {
            InitializeComponent();

            this.rolDao = new RolDAO<Rol>();
            this.cargarDataGridRoles();
        }

        public ResultadosBusqueda(List<Cliente> clientesACargar)
        {
            InitializeComponent();

            this.clienteDao = new ClienteDAO<Cliente>();
            this.cargarDataGridClientes(clientesACargar);
        }

        public ResultadosBusqueda(List<Empresa> empresasACargar)
        {
            InitializeComponent();

            this.empresaDao = new EmpresaDAO<Empresa>();
            this.cargarDataGridEmpresas(empresasACargar);
        }

        public ResultadosBusqueda(List<Sucursal> sucursalesACargar)
        {
            InitializeComponent();

            this.sucursalDao = new SucursalDAO<Sucursal>();
            this.cargarDataGridSucursales(sucursalesACargar);
        }

        public ResultadosBusqueda(List<Factura> facturasACargar)
        {
            InitializeComponent();

            this.facturaDao = new FacturaDAO<Factura>();
            this.cargarDataGridFacturas(facturasACargar);
        }

        public ResultadosBusqueda(List<Rendicion> rendicionesACargar)
        {
            InitializeComponent();

            this.rendicionDao = new RendicionDAO<Rendicion>();
            this.cargarDataGridRendiciones(rendicionesACargar);
        }

        private void cargarDataGridRoles()
        {
            this.rolesEncontrados = this.rolDao.findRol();

            DataTable resultadosRoles = new DataTable();

            resultadosRoles.Columns.Add("Nombre");
            resultadosRoles.Columns.Add("Descripcion");
            resultadosRoles.Columns.Add("Habilitado");

            foreach (Rol rolActual in this.rolesEncontrados)
            {
                resultadosRoles.Rows.Add(rolActual.nombre, rolActual.descripcion, rolActual.habilitado);
            }

            resultadosGrid.DataSource = resultadosRoles;
        }

        private void cargarDataGridClientes(List<Cliente> clientes)
        {
            this.clientesEncontrados = clientes;

            DataTable resultadosClientes = new DataTable();

            resultadosClientes.Columns.Add("DNI");
            resultadosClientes.Columns.Add("Apellido");
            resultadosClientes.Columns.Add("Nombre");
            resultadosClientes.Columns.Add("Mail");

            foreach (Cliente cliente in clientes)
            {
                resultadosClientes.Rows.Add(cliente.dni, cliente.apellido, cliente.nombre, cliente.mail);
            }

            resultadosGrid.DataSource = resultadosClientes;
        }

        private void cargarDataGridEmpresas(List<Empresa> empresas)
        {
            this.empresasEncontradas = empresas;

            DataTable resultadosEmpresas = new DataTable();

            resultadosEmpresas.Columns.Add("CUIT");
            resultadosEmpresas.Columns.Add("Nombre");
            resultadosEmpresas.Columns.Add("Direccion");
            resultadosEmpresas.Columns.Add("Activa");

            foreach (Empresa empresa in empresas)
            {
                resultadosEmpresas.Rows.Add(empresa.cuit, empresa.nombre, empresa.direccion, empresa.activo);
            }

            resultadosGrid.DataSource = resultadosEmpresas;
        }

        private void cargarDataGridSucursales(List<Sucursal> sucursales)
        {
            this.sucursalesEncontradas = sucursales;

            DataTable resultadosSucursales = new DataTable();

            resultadosSucursales.Columns.Add("Nombre");
            resultadosSucursales.Columns.Add("Direccion");
            resultadosSucursales.Columns.Add("Codigo Postal");
            resultadosSucursales.Columns.Add("Activa");

            foreach (Sucursal sucursal in sucursales)
            {
                resultadosSucursales.Rows.Add(sucursal.nombre, sucursal.direccion, sucursal.codigoPostal, sucursal.activo);
            }

            resultadosGrid.DataSource = resultadosSucursales;
        }

        private void cargarDataGridFacturas(List<Factura> facturas)
        {
            this.facturasEncontradas = facturas;

            DataTable resultadosFacturas = new DataTable();

            resultadosFacturas.Columns.Add("Numero");
            resultadosFacturas.Columns.Add("Fecha Alta");
            resultadosFacturas.Columns.Add("Total");
            resultadosFacturas.Columns.Add("Fecha Vencimiento");

            foreach (Factura factura in facturas)
            {
                resultadosFacturas.Rows.Add(factura.numero, factura.fechaAlta, factura.total, factura.fechaVencimiento);
            }

            resultadosGrid.DataSource = resultadosFacturas;
        }

        private void cargarDataGridRendiciones(List<Rendicion> rendiciones)
        {
            this.rendicionesEncontradas = rendiciones;

            DataTable resultadosRendiciones = new DataTable();

            resultadosRendiciones.Columns.Add("ID");
            resultadosRendiciones.Columns.Add("Empresa");
            resultadosRendiciones.Columns.Add("Cantidad de facturas rendidas");
            resultadosRendiciones.Columns.Add("Fecha");
            resultadosRendiciones.Columns.Add("Comision");
            resultadosRendiciones.Columns.Add("Total");
            resultadosRendiciones.Columns.Add("Porcentaje");

            foreach (Rendicion rendicion in rendiciones)
            {
                resultadosRendiciones.Rows.Add(rendicion.id,
                                            rendicion.idEmpresa,
                                            rendicion.cantidadFacturas,
                                            rendicion.fecha,
                                            rendicion.comision,
                                            rendicion.valorTotal,
                                            rendicion.porcentaje);
            }

            resultadosGrid.DataSource = resultadosRendiciones;
        }

        public Rol getRolSeleccionado()
        {
            return this.rolSeleccionado;
        }

        public Cliente getClienteSeleccionado()
        {
            return this.clienteSeleccionado;
        }

        public Empresa getEmpresaSeleccionada()
        {
            return this.empresaSeleccionada;
        }

        public Sucursal getSucursalSeleccionada()
        {
            return this.sucursalSeleccionada;
        }

        public Factura getFacturaSeleccionada()
        {
            return this.facturaSeleccionada;
        }

        public Rendicion getRendicionSeleccionada()
        {
            return this.rendicionSeleccionada;
        }

        // Eventos
        // Boton Aceptar
        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (resultadosGrid.SelectedCells.Count == 0)
            {
                return;
            }
            int index = this.resultadosGrid.SelectedCells[0].RowIndex;

            if (this.rolesEncontrados != null)
            {
                this.rolSeleccionado = new Rol();

                String nombreRol = this.resultadosGrid.Rows[index].Cells[0].Value.ToString();

                this.rolSeleccionado = this.rolesEncontrados.Find(rol => rol.nombre.Equals(nombreRol));
            }
            else if (this.clientesEncontrados != null)
            {
                this.clienteSeleccionado = new Cliente();

                String mailCliente = this.resultadosGrid.Rows[index].Cells[3].Value.ToString();

                this.clienteSeleccionado = this.clientesEncontrados.Find(cliente => cliente.mail.Equals(mailCliente));
            }
            else if (this.empresasEncontradas != null)
            {
                this.empresaSeleccionada = new Empresa();

                String cuitEmpresa = this.resultadosGrid.Rows[index].Cells[0].Value.ToString();

                this.empresaSeleccionada = this.empresasEncontradas.Find(empresa => empresa.cuit.Equals(cuitEmpresa));
            }
            else if (this.sucursalesEncontradas != null)
            {
                this.sucursalSeleccionada = new Sucursal();

                String codigoPostalSucursal = this.resultadosGrid.Rows[index].Cells[2].Value.ToString();

                this.sucursalSeleccionada = this.sucursalesEncontradas.Find(sucursal => sucursal.codigoPostal.Equals(codigoPostalSucursal));
            }
            else if (this.facturasEncontradas != null)
            {
                this.facturaSeleccionada = new Factura();

                int numeroFactura = Int32.Parse(this.resultadosGrid.Rows[index].Cells[0].Value.ToString());

                this.facturaSeleccionada = this.facturasEncontradas.Find(factura => factura.numero == numeroFactura);
            }
            else if (this.rendicionesEncontradas != null)
            {
                this.rendicionSeleccionada = new Rendicion();

                int id = Int32.Parse(this.resultadosGrid.Rows[index].Cells[0].Value.ToString());

                this.rendicionSeleccionada = this.rendicionesEncontradas.Find(rendicion => rendicion.id == id);
            }

            this.Close();
        }

        // Boton Volver
        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
