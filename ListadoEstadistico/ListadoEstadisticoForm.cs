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

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {

        private String porcentajeFacturasEmpresas = "Porcentaje de facturas cobradas por empresa";
        private String mayorRendicion = "Empresas con mayor monto rendido";
        private String masPagos = "Clientes con mas pagos";
        private String porcentajeFacturasClientes = "Clientes con mayor porcentaje de facturas pagadas";

        private int opcionElegida = 0;
        private int trimestreElegido = 0;
        private int anio = 2017;

        private PorcentajeCobradasPorEmpresaDao<PorcentajePagadoEstadistico> porcentajePagadoEstadisticoDao;
        private EmpresasConMontoRendidoDao<EmpresaConMontoRendido> empresaConMontoRendidoDao;
        private ClienteConPagosDAO<ClienteConPagos> clienteConPagosDao;
        private ClientePorcentajeFacturasPagadas<PorcentajeFacturasPagadas> clientePorcentajeFacturasPagadas;

        // Constructores
        public ListadoEstadisticoForm()
        {
            InitializeComponent();
            porcentajePagadoEstadisticoDao = new PorcentajeCobradasPorEmpresaDao<PorcentajePagadoEstadistico>();
            empresaConMontoRendidoDao = new EmpresasConMontoRendidoDao<EmpresaConMontoRendido>();
            clienteConPagosDao = new ClienteConPagosDAO<ClienteConPagos>();
            clientePorcentajeFacturasPagadas = new ClientePorcentajeFacturasPagadas<PorcentajeFacturasPagadas>();
            Utils.iniciarGrids(resultadosGrid);
            this.cargarTipos();
            this.cargarTrimestres();
        }

        private void cargarTipos()
        {
            var dataSource = new List<String>();

            dataSource.Add(porcentajeFacturasEmpresas);
            dataSource.Add(mayorRendicion);
            dataSource.Add(masPagos);
            dataSource.Add(porcentajeFacturasClientes);

            this.tipoCombo.DataSource = dataSource;
            this.tipoCombo.SelectedIndex = 0;
        }

        private void cargarTrimestres()
        {
            var dataSource = new List<String>();

            dataSource.Add("1");
            dataSource.Add("2");
            dataSource.Add("3");
            dataSource.Add("4");

            this.trimestreCombo.DataSource = dataSource;
            this.trimestreCombo.SelectedIndex = 0;
        }

        // Eventos
        // Boton Ejecutar
        private void botonEjecutar_Click(object sender, EventArgs e)
        {
            if (opcionElegida == 0)
            {
                List<PorcentajePagadoEstadistico> result = porcentajePagadoEstadisticoDao.obtenerPorcentajesCobrados(anio, trimestreElegido);
                cargarGrid(result);
            }
            if (opcionElegida == 1)
            {
                List<EmpresaConMontoRendido> result = empresaConMontoRendidoDao.obtenerMayoresMontosRendidos(anio, trimestreElegido);
                cargarGrid(result);
            }

            if (opcionElegida == 2)
            {
                List<ClienteConPagos> result = clienteConPagosDao.obtenerClientesConMasPagos(anio, trimestreElegido);
                cargarGrid(result);
            }
            if (opcionElegida == 3)
            {
                List<PorcentajeFacturasPagadas> result = clientePorcentajeFacturasPagadas.obtenerPorcentajeFacturasPagadas(anio, trimestreElegido);
                cargarGrid(result);
            }
        }

        private void cargarGrid(List<PorcentajePagadoEstadistico> results)
        {
            DataTable gridEstadistica = new DataTable();

            gridEstadistica.Columns.Add("id");
            gridEstadistica.Columns.Add("nombre");
            gridEstadistica.Columns.Add("porcentaje");

            foreach (PorcentajePagadoEstadistico item in results)
            {
                gridEstadistica.Rows.Add(item.id, item.nombre, item.porcentaje);
            }

            resultadosGrid.DataSource = gridEstadistica;
        }

        private void cargarGrid(List<EmpresaConMontoRendido> results)
        {
            DataTable gridEstadistica = new DataTable();

            gridEstadistica.Columns.Add("id");
            gridEstadistica.Columns.Add("nombre");
            gridEstadistica.Columns.Add("monto rendido");

            foreach (EmpresaConMontoRendido item in results)
            {
                gridEstadistica.Rows.Add(item.id, item.nombre, item.montoRendido);
            }

            resultadosGrid.DataSource = gridEstadistica;
        }

        private void cargarGrid(List<ClienteConPagos> results)
        {
            DataTable gridEstadistica = new DataTable();

            gridEstadistica.Columns.Add("id_cliente");
            gridEstadistica.Columns.Add("apellido");
            gridEstadistica.Columns.Add("nombre");
            gridEstadistica.Columns.Add("pagos");

            foreach (ClienteConPagos item in results)
            {
                gridEstadistica.Rows.Add(item.idCliente, item.apellido, item.nombre, item.pagos);
            }

            resultadosGrid.DataSource = gridEstadistica;
            Utils.iniciarGrids(resultadosGrid);
        }

        private void cargarGrid(List<PorcentajeFacturasPagadas> results)
        {
            DataTable gridEstadistica = new DataTable();

            gridEstadistica.Columns.Add("id_cliente");
            gridEstadistica.Columns.Add("apellido");
            gridEstadistica.Columns.Add("nombre");
            gridEstadistica.Columns.Add("porcentaje pagado");

            foreach (PorcentajeFacturasPagadas item in results)
            {
                gridEstadistica.Rows.Add(item.idCliente, item.apellido, item.nombre, item.porcentajePagados);
            }

            resultadosGrid.DataSource = gridEstadistica;
            Utils.iniciarGrids(resultadosGrid);
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox castSender = (System.Windows.Forms.ComboBox)sender;
            if (castSender.SelectedItem.Equals(porcentajeFacturasEmpresas))
            {
                opcionElegida = 0;
            }
            if (castSender.SelectedItem.Equals(mayorRendicion))
            {
                opcionElegida = 1;
            }
            if (castSender.SelectedItem.Equals(masPagos))
            {
                opcionElegida = 2;
            }
            if (castSender.SelectedItem.Equals(porcentajeFacturasClientes))
            {
                opcionElegida = 3;
            }
        }

        private void anioNumeric_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.NumericUpDown castSender = (System.Windows.Forms.NumericUpDown)sender;
            anio = Int32.Parse(castSender.Value.ToString());
        }

        private void trimestreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox castSender = (System.Windows.Forms.ComboBox)sender;
            if (castSender.SelectedItem.Equals("1"))
            {
                trimestreElegido = 1;
            }
            if (castSender.SelectedItem.Equals("2"))
            {
                trimestreElegido = 2;
            }
            if (castSender.SelectedItem.Equals("3"))
            {
                trimestreElegido = 3;
            }
            if (castSender.SelectedItem.Equals("4"))
            {
                trimestreElegido = 4;
            }
        }
    }
}
