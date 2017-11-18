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

namespace PagoAgilFrba.RendicionesPKG
{
    public partial class RendicionAltaFrm : Form
    {
        private int diaSeleccionado=1;
        private int mesSeleccionado = 1;
        private int anioSeleccionado = 2017;
        private int empresaIdSeleccionado = 0;
        private Dictionary<int, bool> habilitado;
        private EmpresaDAO<Empresa> empresaDao;
        private Dictionary<int, int> empresasIds;
        private Dictionary<String, int> meses;

        public RendicionAltaFrm()
        {
            InitializeComponent();
            inicializarMesCombo();
            this.habilitado = new Dictionary<int, bool>();
            this.empresaDao = new EmpresaDAO<Empresa>();
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
            habilitado = new Dictionary<int, bool>();
            this.empresasIds = new Dictionary<int, int>();
            int i = 0;
            foreach (Empresa empresa in empresas)
            {
                empresasIds.Add(i, empresa.id);
                habilitado.Add(empresa.id, empresa.activo);
                this.empresaIdCombo.Items.Add(empresa.nombre);
                i++;
            }
            this.empresaIdSeleccionado = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal n;
            bool isNumeric = decimal.TryParse(this.comisionText.Text, out n);
            if (!isNumeric || this.empresaIdSeleccionado == 0)
            {
                MessageBox.Show("Ingrese por favor una comision y una empresa valida");
            }
            else if (habilitado[empresaIdSeleccionado])
            {
                try
                {
                    int returnValue = empresaDao.rendirEmpresa(empresaIdSeleccionado, anioSeleccionado, mesSeleccionado, diaSeleccionado, n);
                    if (returnValue == 0)
                    {
                        MessageBox.Show("Empresa rendida");
                    }
                    else if (returnValue == 1)
                    {
                        MessageBox.Show("Ya hay una rendicion en el mes y año indicado");
                    }
                    else if (returnValue == 2)
                    {
                        MessageBox.Show("No hay facturas que rendir en el mes y año seleccionado");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error en la fecha seleccionada");
                    }

                }
                catch (SqlException s)
                {
                    MessageBox.Show("Hubo un error en la rendicion");
                }
            }
            else
            {
                MessageBox.Show("La empresa no esta habilitada. No es posible realizar rendicion");
            }
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
