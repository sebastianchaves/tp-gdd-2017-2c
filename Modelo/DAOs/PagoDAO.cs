using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class PagoDAO<T> : Dao<T>
    {
        private const String TABLA = "GD2C2017.ROCKET_DATABASE.PAGOS";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public PagoDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("fechaCobro");
            allColumnsInDB.Add("importe");
            allColumnsInDB.Add("idFormaPago");
            allColumnsInDB.Add("idSucursal");

            allColumnsInDB.Add("id_pago");
            allColumnsInDB.Add("fecha_cobro");
            allColumnsInDB.Add("importe");
            allColumnsInDB.Add("id_forma_pago");
            allColumnsInDB.Add("id_sucursal");
        }

    }
}
