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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class BajaSucursal : Form
    {

        // Atributos
        private Util utils;
        private SucursalDAO sucursalDao;
        private Sucursal sucursalSeleccionada;

        // Constructores
        public BajaSucursal()
        {
            InitializeComponent();

            this.utils = new Util();
            this.sucursalDao = new SucursalDAO();
            this.utils.iniciarGrids(this.resultadosGrid);
        }

        // Metodos
        private void deshabilitarSucursal()
        {
            this.sucursalSeleccionada.habilitada = false;
            this.sucursalDao.updateSucursal(this.sucursalSeleccionada);
            this.sucursalSeleccionada = new Sucursal();
            MessageBox.Show("Sucursal deshabilitada!");
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.utils.iniciarGrids(this.resultadosGrid);

            using (BusquedaSucursal busquedaForm = new BusquedaSucursal(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);
                this.botonDeshabilitar.Enabled = true;
            }
        }

        // Boton Deshabilitar
        private void botonDeshabilitar_Click(object sender, EventArgs e)
        {
            var sucursalIndex = resultadosGrid.SelectedCells[0].RowIndex;
            this.sucursalSeleccionada = new Sucursal();
            int codigoPostalSeleccionado = Int32.Parse(resultadosGrid.Rows[sucursalIndex].Cells[2].Value.ToString());
            this.sucursalSeleccionada = this.sucursalDao.findSucursal("", "", codigoPostalSeleccionado).ElementAt(sucursalIndex);
            this.deshabilitarSucursal();
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

    }
}
