using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class DevolucionRendicionDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.DEVOLUCION_RENDICION";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public DevolucionRendicionDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("idDevolucion");
            allColumns.Add("idRendicion");

            allColumnsInDB.Add("id_devolucion");
            allColumnsInDB.Add("id_rendicion");
        }

        // Inserts
        public void agregarDevolucionRendicion(DevolucionRendicion devolucionRendicion)
        {
            List<String> valores = new List<String>();

            valores.Add(devolucionRendicion.idDevolucion.ToString());
            valores.Add(devolucionRendicion.idRendicion.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

    }
}
