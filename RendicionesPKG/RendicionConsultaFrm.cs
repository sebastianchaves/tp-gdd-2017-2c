using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
using PagoAgilFrba.Modelo.Utils;
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

namespace PagoAgilFrba.RendicionesPKG
{
    public partial class RendicionConsultaFrm : Form
    {
        private int diaSeleccionado=1;
        private int mesSeleccionado = 1;
        private int anioSeleccionado = 2017;
        private int empresaIdSeleccionado = 0;
        private EmpresaDAO<Empresa> empresaDao;
        private RendicionDAO<Rendicion> rendicionDao;
        private Dictionary<int, int> empresasIds;
        private Dictionary<String, int> meses;

        public RendicionConsultaFrm()
        {
            InitializeComponent();
            inicializarMesCombo();
            Utils.iniciarGrids(this.rendicionesDataGrid);
            this.empresaDao = new EmpresaDAO<Empresa>();
            this.rendicionDao = new RendicionDAO<Rendicion>();
            for (int i = 1; i < 29; i++)
            {
                String dia = i.ToString();
                this.diaRendicionCombo.Items.Add(dia);
            }
            this.diaRendicionCombo.SelectedIndex = 0;

            mesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            diaRendicionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            empresaIdCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void inicializarMesCombo()
        {
            meses = new Dictionary<string, int>();
            meses.Add("Enero", 0);
            meses.Add("Febrero", 1);
            meses.Add("Marzo", 2);
            meses.Add("Abril", 3);
            meses.Add("Mayo", 4);
            meses.Add("Junio", 5);
            meses.Add("Julio", 6);
            meses.Add("Agosto", 7);
            meses.Add("Septiembre", 8);
            meses.Add("Octubre", 9);
            meses.Add("Noviembre", 10);
            meses.Add("Diciembre", 11);

            mesCombo.Items.Add("Enero");
            mesCombo.Items.Add("Febrero");
            mesCombo.Items.Add("Marzo");
            mesCombo.Items.Add("Abril");
            mesCombo.Items.Add("Mayo");
            mesCombo.Items.Add("Junio");
            mesCombo.Items.Add("Julio");
            mesCombo.Items.Add("Agosto");
            mesCombo.Items.Add("Septiembre");
            mesCombo.Items.Add("Octubre");
            mesCombo.Items.Add("Noviembre");
            mesCombo.Items.Add("Diciembre");
            mesCombo.SelectedIndex = 0;
        }

        private void diaRendicionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            diaSeleccionado = Int32.Parse(combo.SelectedItem.ToString());
            updateCLienteBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox) sender;
            this.empresaIdSeleccionado = empresasIds[combo.SelectedIndex];
        }

        private void updateCLienteBox()
        {
            List<Empresa> empresas = empresaDao.obtenerEmpresasPorDiaDeRendicion(diaSeleccionado);
            this.empresaIdCombo.Items.Clear();
            this.empresaIdCombo.Text = null;
            this.empresasIds = new Dictionary<int, int>();
            int i = 0;
            foreach (Empresa empresa in empresas)
            {
                empresasIds.Add(i, empresa.id);
                this.empresaIdCombo.Items.Add(empresa.nombre);
                i++;
            }
            this.empresaIdSeleccionado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable gridEstadistica = new DataTable();

            gridEstadistica.Columns.Add("cantidad facturas");
            gridEstadistica.Columns.Add("fecha");
            gridEstadistica.Columns.Add("comision");
            gridEstadistica.Columns.Add("valor total");
            gridEstadistica.Columns.Add("porcentaje");
            gridEstadistica.Columns.Add("empresa");

            List<Rendicion> results = 
                rendicionDao.filtrarRendiciones(empresaIdSeleccionado, mesSeleccionado.ToString(), anioSeleccionado.ToString());

            foreach (Rendicion item in results)
            {
                gridEstadistica.Rows.Add(item.cantidadFacturas, item.fecha, item.comision, item.valorTotal, item.porcentaje, item.nombreEmpresa);
            }

            rendicionesDataGrid.DataSource = gridEstadistica;
        }

        private void mesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            mesSeleccionado = meses[combo.SelectedItem.ToString()] + 1;
        }

        private void anioCombo_ValueChanged(object sender, EventArgs e)
        {
            anioSeleccionado = Int32.Parse(((NumericUpDown)sender).Value.ToString());
        }
    }
}
