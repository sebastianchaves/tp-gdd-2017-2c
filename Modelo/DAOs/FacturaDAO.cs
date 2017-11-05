using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class FacturaDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.FACTURAS";
        private const String TODOS_LAS_FACTURAS = "select f.*, (select count(1) from ROCKET_DATABASE.PAGO_FACTURA pf where pf.id_factura = f.id_factura) as pagada from ROCKET_DATABASE.FACTURAS f where f.nro_factura = ";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public FacturaDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);

            allColumns.Add("id");
            allColumns.Add("numero");
            allColumns.Add("fechaAlta");
            allColumns.Add("total");
            allColumns.Add("fechaVencimiento");
            allColumns.Add("idRendicion");
            allColumns.Add("idCliente");
            allColumns.Add("idEmpresa");
            allColumns.Add("pagada");

            allColumnsInDB.Add("id_factura");
            allColumnsInDB.Add("nro_factura");
            allColumnsInDB.Add("fecha_alta");
            allColumnsInDB.Add("total");
            allColumnsInDB.Add("fecha_vencimiento");
            allColumnsInDB.Add("id_rendicion");
            allColumnsInDB.Add("id_cliente");
            allColumnsInDB.Add("id_empresa");
        }

        // Inserts
        public int agregarFactura(Factura factura)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(factura.numero.ToString());
            valores.Add(factura.fechaAlta.ToString());
            valores.Add(factura.total.ToString());
            valores.Add(factura.fechaVencimiento.ToString());
            valores.Add("null");
            valores.Add(factura.idCliente.ToString());
            valores.Add(factura.idEmpresa.ToString());

            return insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Selects
        public List<T> obtenerFacturas(int numeroFactura)
        {
            return obtenerPorQueryGenerica(TODOS_LAS_FACTURAS + numeroFactura.ToString(), allColumns, tipos);
        }

    }
}
