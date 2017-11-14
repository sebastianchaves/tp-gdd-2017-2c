using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class DevolucionDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.DEVOLUCIONES";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public DevolucionDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);

            allColumns.Add("id");
            allColumns.Add("fecha");
            allColumns.Add("idTipoDevolucion");
            allColumns.Add("motivo");

            allColumnsInDB.Add("id_devolucion");
            allColumnsInDB.Add("fecha");
            allColumnsInDB.Add("id_tipo_devolucion");
            allColumnsInDB.Add("motivo_devolucion");
        }

        // Inserts
        public int agregarDevolucion(Devolucion devolucion)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(Utils.Utils.formatDateTime(devolucion.fecha));
            valores.Add(devolucion.idTipoDevolucion.ToString());
            valores.Add(devolucion.motivo);

            return insert(TABLA, allColumnsInDB, tipos, valores, true);
        }

    }
}
