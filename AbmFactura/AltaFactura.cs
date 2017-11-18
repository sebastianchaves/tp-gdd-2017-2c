using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
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

namespace PagoAgilFrba.AbmFactura
{
    public partial class AltaFactura : Form
    {

        private Cliente clienteEncontrado;
        private Empresa empresaEncontrada;
        private Factura nuevaFactura;

        private FacturaDAO<Factura> facturaDao;
        private ConceptoDAO<Concepto> conceptoDao;

        private List<Concepto> conceptosAgregados;
        private Concepto nuevoConcepto;

        public AltaFactura()
        {
            InitializeComponent();

            this.nuevaFactura = new Factura();

            this.facturaDao = new FacturaDAO<Factura>();
            this.conceptoDao = new ConceptoDAO<Concepto>();

            this.conceptosAgregados = new List<Concepto>();
            this.nuevoConcepto = new Concepto();

            this.iniciarConceptosGrid();

            this.setFechasDefault();
        }

        private void setFechasDefault()
        {
            this.fechaAltaInput.CustomFormat = "";
            this.fechaVencimientoInput.CustomFormat = "";

            this.fechaAltaInput.Value = Utils.appDate;
            this.nuevaFactura.fechaAlta = this.fechaAltaInput.Value;

            this.fechaVencimientoInput.Value = Utils.appDate;
            this.nuevaFactura.fechaVencimiento = this.fechaVencimientoInput.Value;
        }

        private void iniciarConceptosGrid()
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");

            conceptosGrid.DataSource = resultadosConceptos;
        }

        private void agregarConcepto()
        {
            if (this.camposConceptoCompletos())
            {
                if (Validaciones.campoNumericoMayorA0(montoInput.Text) && Validaciones.campoNumericoMayorA0(cantidadInput.Text))
                {
                    this.conceptosAgregados.Add(nuevoConcepto);
                    this.agregarAGrid();
                }
                else
                {
                    MessageBox.Show("Campos con datos invalidos. Ambos valores deben ser mayores a 0");
                }
            }
            else
            {
                MessageBox.Show("Complete los datos faltantes del concepto...");
            }
        }

        private void agregarAGrid()
        {
            DataTable resultadosConceptos = new DataTable();

            resultadosConceptos.Columns.Add("Monto");
            resultadosConceptos.Columns.Add("Cantidad");
            resultadosConceptos.Columns.Add("Descripcion");

            foreach (Concepto concepto in this.conceptosAgregados)
            {
                resultadosConceptos.Rows.Add(concepto.monto, concepto.cantidad, concepto.descripcion);
            }

            conceptosGrid.DataSource = resultadosConceptos;
        }

        private Boolean camposConceptoCompletos()
        {
            return this.cantidadInput.Text != "" && this.montoInput.Text != "";
        }

        private void agregarFactura()
        {
            try
            {
                if (this.camposCompletos())
                {
                    if (this.empresaEncontrada.activo)
                    {
                        if (nuevaFactura.fechaVencimiento > nuevaFactura.fechaAlta)
                        {
                            if (facturaDao.obtenerFacturas(nuevaFactura.numero).Count == 0)
                            {
                                this.calcularTotal();
                                this.facturaDao.agregarFactura(this.nuevaFactura);
                                this.agregarConceptos();
                                MessageBox.Show("Factura agregada!");
                                Utils.clearTextBoxes(this);
                                this.conceptosGrid.DataSource = null;
                                this.conceptosGrid.Rows.Clear();
                                this.nuevaFactura = new Factura();
                                this.conceptosAgregados = new List<Concepto>();
                            }
                            else
                            {
                                MessageBox.Show("El numero de factura ya existe");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha de vencimiento debe ser mayor a la fecha de alta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La empresa seleccionada esta inhabilitada, no se puede cargar la factura");
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos faltantes.");
                }
            }
            catch (SqlException s)
            {
                MessageBox.Show("Error inesperado en la carga de factura");
            }

        }

        private Boolean camposCompletos()
        {
            return this.clienteEncontrado != null &&
                this.empresaEncontrada != null &&
                this.numeroInput.Text != "" &&
                this.fechaAltaInput.Value.ToString() != "" &&
                this.fechaVencimientoInput.Value.ToString() != "" &&
                this.hayConceptos();
        }

        private Boolean hayConceptos()
        {
            return this.conceptosGrid.Rows.Count > 0;
        }

        private void agregarConceptos()
        {
            int idNuevaFactura = this.facturaDao.obtenerFacturas(this.nuevaFactura.numero).ElementAt(0).id;

            foreach (Concepto concepto in this.conceptosAgregados)
            {
                concepto.idFactura = idNuevaFactura;

                this.conceptoDao.agregarConcepto(concepto);
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            foreach (Concepto concepto in this.conceptosAgregados)
            {
                total += (concepto.cantidad * concepto.monto);
            }

            this.nuevaFactura.total = total;
        }

        // Eventos
        // Boton Aceptar
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.agregarFactura();
        }

        // Boton Buscar Cliente
        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (BusquedaCliente busquedaForm = new BusquedaCliente())
            {
                busquedaForm.ShowDialog(this);
                this.clienteEncontrado = busquedaForm.getClienteEncontrado();
                if (clienteEncontrado != null)
                {
                    this.clienteInput.Text = this.clienteEncontrado.nombre;
                    this.nuevaFactura.idCliente = this.clienteEncontrado.id;
                }
            }
        }

        // Boton Buscar Empresa
        private void botonBuscarEmpresa_Click(object sender, EventArgs e)
        {
            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa())
            {
                busquedaForm.ShowDialog(this);
                this.empresaEncontrada = busquedaForm.getEmpresaEncontrada();
                if (empresaEncontrada != null)
                {
                    this.empresaInput.Text = this.empresaEncontrada.nombre;
                    this.nuevaFactura.idEmpresa = this.empresaEncontrada.id;
                }
            }
        }

        // Boton Agregar Concepto
        private void botonAgregarConcepto_Click(object sender, EventArgs e)
        {
            this.agregarConcepto();
            this.nuevoConcepto = new Concepto();
            this.cantidadInput.Clear();
            this.montoInput.Clear();
            this.descripcionInput.Clear();
        }

        // Boton Eliminar Concepto
        private void botonEliminarConcepto_Click(object sender, EventArgs e)
        {
            if (this.conceptosGrid.SelectedCells.Count > 0)
            {
                int index = this.conceptosGrid.SelectedCells[0].RowIndex;

                try
                {
                    decimal conceptoMonto = Decimal.Parse(this.conceptosGrid.Rows[index].Cells[0].Value.ToString());
                    int conceptoCantidad = Int32.Parse(this.conceptosGrid.Rows[index].Cells[1].Value.ToString());
                    Concepto conceptoAEliminar = this.conceptosAgregados.Find(concepto => concepto.cantidad == conceptoCantidad && concepto.monto == conceptoMonto);
                    this.conceptosAgregados.Remove(conceptoAEliminar);
                    this.agregarAGrid();
                }
                catch (Exception)
                {
                    
                }
            }
        }

        // Boton Volver
        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carga Monto
        private void montoInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.nuevoConcepto.monto = Decimal.Parse(this.montoInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, montoTooltip, montoInput);
            }
        }

        // Carga Cantidad
        private void cantidadInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.nuevoConcepto.cantidad = Int32.Parse(this.cantidadInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, cantidadTooltip, cantidadInput);
            }
        }

        // Carga Numero
        private void numeroInput_Leave(object sender, EventArgs e)
        {
            try
            {
                this.nuevaFactura.numero = Int32.Parse(this.numeroInput.Text);
            }
            catch (Exception ex)
            {
                Utils.catchearErrorFormato(ex, numeroTooltip, numeroInput);
            }
        }

        // Carga Fecha Alta
        private void fechaAltaInput_Leave(object sender, EventArgs e)
        {
            this.nuevaFactura.fechaAlta = this.fechaAltaInput.Value;
        }

        // Carga Fecha Vencimiento
        private void fechaVencimientoInput_Leave(object sender, EventArgs e)
        {
            this.nuevaFactura.fechaVencimiento = this.fechaVencimientoInput.Value;
        }

        private void descripcionInput_TextChanged(object sender, EventArgs e)
        {
            this.nuevoConcepto.descripcion = this.descripcionInput.Text;
        }

    }
}
