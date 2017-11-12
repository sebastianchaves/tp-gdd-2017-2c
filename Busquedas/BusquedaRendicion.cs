using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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
    public partial class BusquedaRendicion : Form
    {

        private Rendicion rendicionEncontrada;
        private RendicionDAO<Rendicion> rendicionDao;
        private EmpresaDAO<Empresa> empresaDao;
        private Empresa empresaABuscar;
        private String anioABuscar;
        private String mesABuscar;

        private Dictionary<int, Empresa> indexComboNombreEmpresa;

        public BusquedaRendicion()
        {
            InitializeComponent();

            this.anioABuscar = "2017";
            this.mesABuscar = "1";

            this.rendicionDao = new RendicionDAO<Rendicion>();
            this.empresaDao = new EmpresaDAO<Empresa>();
            this.indexComboNombreEmpresa = new Dictionary<int, Empresa>();
            this.rendicionEncontrada = new Rendicion();

            this.cargarEmpresasDisponibles();
        }

        private void cargarEmpresasDisponibles()
        {
            List<Empresa> empresas = this.empresaDao.findEmpresas();

            var dataSource = new List<String>();

            for (int i = 0; i < empresas.Count; i++)
            {
                Empresa empresa = empresas.ElementAt(i);
                dataSource.Add(empresa.nombre);
                this.indexComboNombreEmpresa.Add(i, empresa);
            }
            
            empresasCombo.DataSource = dataSource;
        }

        private Boolean algunFiltroCompleto()
        {
            return this.anioInput.Value.ToString() != "" 
                || this.mesInput.Value.ToString() != "";
        }

        public Rendicion getRendicionEncontrada()
        {
            return this.rendicionEncontrada;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (this.algunFiltroCompleto())
            {
                List<Rendicion> resultados = this.rendicionDao.findRendicion(this.empresaABuscar.id,
                                                                            this.mesABuscar,
                                                                            this.anioABuscar);

                if (resultados.Count() == 0)
                {
                    MessageBox.Show("No existe ninguna rendicion que concuerde con esos parámetros.");
                }
                else if (resultados.Count() > 0)
                {
                    using (ResultadosBusqueda resultadosForm = new ResultadosBusqueda(resultados))
                    {
                        resultadosForm.ShowDialog(this);
                        this.rendicionEncontrada = resultadosForm.getRendicionSeleccionada();
                        this.rendicionEncontrada.nombreEmpresa = this.empresaABuscar.nombre;
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

        // Carga Empresa
        private void empresasCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            this.empresaABuscar = this.indexComboNombreEmpresa[index];
            this.rendicionEncontrada.nombreEmpresa = empresaABuscar.nombre;
        }

        // Carga Mes
        private void mesInput_Leave(object sender, EventArgs e)
        {
            this.mesABuscar = this.mesInput.Value.ToString();
        }

        // Carga Anio
        private void anioInput_Leave(object sender, EventArgs e)
        {
            this.anioABuscar = this.anioInput.Value.ToString();
        }

    }
}
