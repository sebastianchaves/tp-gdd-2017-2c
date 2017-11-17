using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class ConceptoDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.CONCEPTOS";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public ConceptoDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);

            allColumns.Add("id");
            allColumns.Add("monto");
            allColumns.Add("cantidad");
            allColumns.Add("idFactura");
            allColumns.Add("descripcion");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("monto");
            allColumnsInDB.Add("cantidad");
            allColumnsInDB.Add("id_factura");
            allColumnsInDB.Add("descripcion");
        }

        // Inserts
        public void agregarConcepto(Concepto concepto)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(concepto.monto.ToString());
            valores.Add(concepto.cantidad.ToString());
            valores.Add(concepto.idFactura.ToString());
            valores.Add(concepto.descripcion);

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Selects
        public List<T> findConceptos(String idFactura)
        {
            String query = "SELECT * from " + TABLA + " where id_factura = " + idFactura;
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }

        // Updates
        public void updateConcepto(Concepto conceptoUpdate)
        {
            Condicion actualizacion = new Condicion();

            actualizacion.agregarCondicion("monto", conceptoUpdate.monto, Utils.Utils.DECIMAL_TYPE);
            actualizacion.agregarCondicion("cantidad", conceptoUpdate.cantidad, Utils.Utils.INT_TYPE);
            actualizacion.agregarCondicion("id_factura", conceptoUpdate.idFactura, Utils.Utils.INT_TYPE);
            actualizacion.agregarCondicion("descripcion", conceptoUpdate.descripcion, Utils.Utils.STRING_TYPE);

            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_concepto", conceptoUpdate.id, Utils.Utils.INT_TYPE);

            update(TABLA, actualizacion, condicion);
        }

        //Elimina un concepto
        public int deleteConcepto(Concepto conceptoDelete)
        {
            String query = "DELETE from " + TABLA + " where id_concepto = " + conceptoDelete.id;
            return deleteQuery(query);
        }

    }
}
