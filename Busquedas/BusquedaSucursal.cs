using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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

namespace PagoAgilFrba.Busquedas
{
    public partial class BusquedaSucursal : Form
    {

        // Atributos
        private IList<Sucursal> sucursalesEncontradas;
        private SucursalDAO sucursalDao;
        private Util utils;
        private DataGridView resultadosGrid;
        private String nombreABuscar;
        private String direccionABuscar;
        private int codigoPostalABuscar;

        // Constructores
        public BusquedaSucursal(DataGridView resultadosGrid)
        {
            InitializeComponent();

            this.utils = new Util();
            this.sucursalDao = new SucursalDAO();
            this.resultadosGrid = resultadosGrid;
        }

        // Metodos
        private void cargarDataGridSucursales(IList<Sucursal> sucursales)
        {
            DataTable resultadosSucursales = new DataTable();

            resultadosSucursales.Columns.Add("Nombre");
            resultadosSucursales.Columns.Add("Direccion");
            resultadosSucursales.Columns.Add("Codigo Postal");

            foreach (Sucursal sucursal in sucursales)
            {
                resultadosSucursales.Rows.Add(sucursal.nombre, sucursal.direccion, sucursal.codigoPostal);
            }
            resultadosGrid.DataSource = resultadosSucursales;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.sucursalesEncontradas = this.sucursalDao.findSucursal(this.nombreABuscar,
                                                    this.direccionABuscar,
                                                    this.codigoPostalABuscar);
            if (sucursalesEncontradas.Count() == 0)
            {
                MessageBox.Show("No existe ninguna sucursal que concuerde con esos parámetros.");
            }
            else if (sucursalesEncontradas.Count() > 0)
            {
                this.cargarDataGridSucursales(sucursalesEncontradas);
                this.Close();
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga Nombre
        private void nombreInput_Leave(object sender, EventArgs e)
        {
            this.nombreABuscar = this.nombreInput.Text;
        }

        // Carga Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.direccionABuscar = this.direccionInput.Text;
        }

        // Carga Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.codigoPostalABuscar = Int32.Parse(this.codigoPostalInput.Text);
            }
            catch (Exception ex)
            {
                utils.catchearErrorFormato(ex, codigoPostalTooltip, codigoPostalInput);
            }
        }
    }
}
