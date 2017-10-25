using PagoAgilFrba.Busquedas;
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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class BajaEmpresa : Form
    {

        // Atributos
        private Util utils;
        private EmpresaDAO empresaDao;
        private Empresa empresaSeleccionada;

        // Constructores
        public BajaEmpresa()
        {
            InitializeComponent();

            this.utils = new Util();
            this.empresaDao = new EmpresaDAO();
        }

        // Metodos
        private void deshabilitarEmpresa()
        {
            this.empresaSeleccionada.habilitada = false;
            this.empresaDao.updateEmpresa(this.empresaSeleccionada);
            this.empresaSeleccionada = new Empresa();
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.utils.iniciarGrids(this.resultadosGrid);

            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);
                this.botonDeshabilitar.Enabled = true;
            }
        }

        // Boton Deshabilitar
        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {
            var empresaIndex = resultadosGrid.SelectedCells[0].RowIndex;
            this.empresaSeleccionada = new Empresa();
            int cuitSeleccionado = Int32.Parse(resultadosGrid.Rows[empresaIndex].Cells[1].Value.ToString());
            this.empresaSeleccionada = this.empresaDao.findEmpresa("", cuitSeleccionado, "").ElementAt(empresaIndex);
            this.deshabilitarEmpresa();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
