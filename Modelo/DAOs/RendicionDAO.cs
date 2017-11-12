using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class RendicionDAO<T> : Dao<T>
    {
        private const String TABLA = "GD2C2017.ROCKET_DATABASE.RENDICIONES";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public RendicionDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumnsInDB.Add("idRendicion");
            allColumnsInDB.Add("cantidadFacturas");
            allColumnsInDB.Add("fecha");
            allColumnsInDB.Add("comision");
            allColumnsInDB.Add("valorTotal");
            allColumnsInDB.Add("porcentaje");
            allColumnsInDB.Add("idEmpresa");

            allColumnsInDB.Add("id_rendicion");
            allColumnsInDB.Add("cantidad_facturas");
            allColumnsInDB.Add("fecha");
            allColumnsInDB.Add("comision");
            allColumnsInDB.Add("valor_total");
            allColumnsInDB.Add("porcentaje");
            allColumnsInDB.Add("id_empresa");
        }

    }
}
