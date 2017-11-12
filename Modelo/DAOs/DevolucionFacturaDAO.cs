using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class DevolucionFacturaDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.DEVOLUCION_FACTURA";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public DevolucionFacturaDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("idDevolucion");
            allColumns.Add("idFactura");

            allColumnsInDB.Add("id_devolucion");
            allColumnsInDB.Add("id_factura");
        }

        // Inserts
        public void agregarDevolucionFactura(DevolucionFactura devolucionFactura)
        {
            List<String> valores = new List<String>();

            valores.Add(devolucionFactura.idDevolucion.ToString());
            valores.Add(devolucionFactura.idFactura.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }
    }
}
