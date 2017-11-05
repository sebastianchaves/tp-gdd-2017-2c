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

        private SucursalDAO<Sucursal> sucursalDao;
        private Sucursal sucursalBuscada;
        private Sucursal sucursalEncontrada;

        public BusquedaSucursal()
        {
            InitializeComponent();

            this.sucursalDao = new SucursalDAO<Sucursal>();
            this.sucursalBuscada = new Sucursal();
            this.sucursalEncontrada = new Sucursal();
        }

        public Sucursal getSucursalEncontrada()
        {
            return this.sucursalEncontrada;
        }

        private Boolean algunFiltroCompleto()
        {
            return this.nombreInput.Text != "" || this.direccionInput.Text != "" || this.codigoPostalInput.Text != "";
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.algunFiltroCompleto())
            {

                List<Sucursal> resultados = this.sucursalDao.findSucursal(this.sucursalBuscada.nombre,
                                        this.sucursalBuscada.direccion,
                                        this.sucursalBuscada.codigoPostal);

                if (resultados.Count() == 0)
                {
                    MessageBox.Show("No existe ninguna sucursal que concuerde con esos parámetros.");
                }
                else if (resultados.Count() > 0)
                {
                    using (ResultadosBusqueda resultadosForm = new ResultadosBusqueda(resultados))
                    {
                        resultadosForm.ShowDialog(this);
                        this.sucursalEncontrada = resultadosForm.getSucursalSeleccionada();
                    }
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
            this.sucursalBuscada.nombre = this.nombreInput.Text;
        }

        // Carga Direccion
        private void direccionInput_Leave(object sender, EventArgs e)
        {
            this.sucursalBuscada.direccion = this.direccionInput.Text;
        }

        // Carga Codigo Postal
        private void codigoPostalInput_Leave(object sender, EventArgs e)
        {
            this.sucursalBuscada.codigoPostal = this.codigoPostalInput.Text;
        }

    }
}
