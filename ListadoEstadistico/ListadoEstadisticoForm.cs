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
        // Constructores
        public ListadoEstadisticoForm()
        {
            InitializeComponent();

            Utils.iniciarGrids(resultadosGrid);
            this.cargarTipos();
            this.cargarCuatrimestres();
        }

        private void cargarTipos()
        {
            var dataSource = new List<String>();

            String porcentajeFacturasEmpresas = "Porcentaje de facturas cobradas por empresa";
            String mayorRendicion = "Empresas con mayor monto rendido";
            String masPagos = "Clientes con mas pagos";
            String porcentajeFacturasClientes = "Clientes con mayor porcentaje de facturas pagadas";

            dataSource.Add(porcentajeFacturasEmpresas);
            dataSource.Add(mayorRendicion);
            dataSource.Add(masPagos);
            dataSource.Add(porcentajeFacturasClientes);

            this.tipoCombo.DataSource = dataSource;
        }

        private void cargarCuatrimestres()
        {
            var dataSource = new List<String>();

            String porcentajeFacturasEmpresas = "1";
            String mayorRendicion = "2";
            String masPagos = "3";
            String porcentajeFacturasClientes = "4s";

            dataSource.Add(porcentajeFacturasEmpresas);
            dataSource.Add(mayorRendicion);
            dataSource.Add(masPagos);
            dataSource.Add(porcentajeFacturasClientes);

            this.trimestreCombo.DataSource = dataSource;
        }

        // Eventos
        // Boton Ejecutar
        private void botonEjecutar_Click(object sender, EventArgs e)
        {

        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
