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

            allColumns.Add("id");
            allColumns.Add("monto");
            allColumns.Add("cantidad");
            allColumns.Add("idFactura");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("monto");
            allColumnsInDB.Add("cantidad");
            allColumnsInDB.Add("id_factura");
        }

        // Inserts
        public void agregarConcepto(Concepto concepto)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(concepto.monto.ToString());
            valores.Add(concepto.cantidad.ToString());
            valores.Add(concepto.idFactura.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

    }
}
