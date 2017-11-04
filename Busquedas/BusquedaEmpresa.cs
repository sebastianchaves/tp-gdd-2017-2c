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
    public partial class BusquedaEmpresa : Form
    {

        private IList<Empresa> empresasEncontradas;
        private EmpresaDAO<Empresa> empresaDao;
        private RubroDAO<Rubro> rubroDao;
        private Utils util;
        private DataGridView resultadosGrid;
        private String nombreABuscar;
        private String cuitABuscar;
        private String rubroABuscar;

        public BusquedaEmpresa()
        {

        }

        public BusquedaEmpresa(DataGridView resultadosGrid)
        {
            InitializeComponent();

            this.util = new Utils();
            this.empresaDao = new EmpresaDAO<Empresa>();
            this.rubroDao = new RubroDAO<Rubro>();
            this.cargarRubrosDisponibles();
            this.resultadosGrid = resultadosGrid;
        }

        private void cargarRubrosDisponibles()
        {
            List<Rubro> rubros = this.rubroDao.findRubros();

            var dataSource = new List<String>();

            foreach (Rubro rubro in rubros)
            {
                dataSource.Add(rubro.nombre);
            }

            rubroCombo.DataSource = dataSource;
        }

        private void cargarDataGridEmpresas(IList<Empresa> empresas)
        {
            DataTable resultadosEmpresas = new DataTable();

            resultadosEmpresas.Columns.Add("Nombre");
            resultadosEmpresas.Columns.Add("Cuit");
            resultadosEmpresas.Columns.Add("Rubro");

            foreach (Empresa empresa in empresas)
            {
                resultadosEmpresas.Rows.Add(empresa.nombre, empresa.cuit, empresa.idRubro);
            }
            resultadosGrid.DataSource = resultadosEmpresas;
        }

        public int getIdEmpresaEncontrada()
        {
            return 1;
        }

        private Boolean algunFiltroCompleto()
        {
            return this.nombreInput.Text != "" || this.cuitInput.Text != "" || this.rubroCombo.Text != "";
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.algunFiltroCompleto())
            {
                this.empresasEncontradas = this.empresaDao.findEmpresa(this.nombreABuscar,
                                                    this.cuitABuscar,
                                                    this.rubroABuscar);
                if (empresasEncontradas.Count() == 0)
                {
                    MessageBox.Show("No existe ninguna empresa que concuerde con esos parámetros.");
                }
                else if (empresasEncontradas.Count() > 0)
                {
                    this.cargarDataGridEmpresas(empresasEncontradas);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete alguno de los filtros disponibles");
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

        // Carga Cuit
        private void cuitInput_Leave(object sender, EventArgs e)
        {
            this.cuitABuscar = cuitInput.Text;
        }

        // Carga Rubro
        private void rubroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rubroABuscar = this.rubroCombo.SelectedItem.ToString();
        }

    }
}
