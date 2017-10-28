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
    public partial class ListadoEstadistico : Form
    {

        // Atributos
        private Dictionary<int, String> tiposListados;
        private Utils utils;

        // Constructores
        public ListadoEstadistico()
        {
            InitializeComponent();

            this.utils = new Utils();
            this.tiposListados = new Dictionary<int, String>();
            this.utils.iniciarGrids(resultadosGrid);
            this.cargarTipos();
        }

        // Metodos
        private void cargarTipos()
        {
            var dataSource = new List<String>();

            String porcentajeFacturasEmpresas = "Porcentaje de facturas cobradas por empresa";
            String mayorRendicion = "Empresas con mayor monto rendido";
            String masPagos = "Clientes con mas pagos";
            String porcentajeFacturasClientes = "Clientes con mayor porcentaje de facturas pagadas (clientes cumplidores)";

            dataSource.Add(porcentajeFacturasEmpresas);
            dataSource.Add(mayorRendicion);
            dataSource.Add(masPagos);
            dataSource.Add(porcentajeFacturasClientes);

            this.tiposListados.Add(0, porcentajeFacturasEmpresas);
            this.tiposListados.Add(1, mayorRendicion);
            this.tiposListados.Add(2, masPagos);
            this.tiposListados.Add(3, porcentajeFacturasClientes);

            this.tipoCombo.DataSource = dataSource;
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
