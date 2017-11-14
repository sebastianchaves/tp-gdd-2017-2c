using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class PagoFacturaDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.PAGO_FACTURA";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public PagoFacturaDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("idFactura");
            allColumns.Add("idPago");

            allColumnsInDB.Add("id_factura");
            allColumnsInDB.Add("id_pago");
        }

        // Inserts
        public void agregarPagoFactura(PagoFactura pagoFactura)
        {
            List<String> valores = new List<String>();

            valores.Add(pagoFactura.idFactura.ToString());
            valores.Add(pagoFactura.idPago.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Delete
        public int delete(PagoFactura pagoFactura)
        {
            String query = "DELETE from " + TABLA +
                " where id_factura = " + pagoFactura.idFactura +
                " and id_pago = " + pagoFactura.idPago;

            return deleteQuery(query);
        }

        // Select
        public List<T> findByIdFactura(int idFactura)
        {
            String query = "SELECT * from " + TABLA +
                " where id_factura = " + idFactura;

            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }

    }
}
