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
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("id");
            allColumns.Add("cantidadFacturas");
            allColumns.Add("fecha");
            allColumns.Add("comision");
            allColumns.Add("valorTotal");
            allColumns.Add("porcentaje");
            allColumns.Add("idEmpresa");

            allColumnsInDB.Add("id_rendicion");
            allColumnsInDB.Add("cantidad_facturas");
            allColumnsInDB.Add("fecha");
            allColumnsInDB.Add("comision");
            allColumnsInDB.Add("valor_total");
            allColumnsInDB.Add("porcentaje");
            allColumnsInDB.Add("id_empresa");
        }

        public List<T> obtenerRendicion(int id)
        {
            String query = "select r.*, e.nombre from ROCKET_DATABASE.rendiciones r, "
            + "ROCKET_DATABASE.EMPRESAS e where r.id_empresa = e.id_empresa and id_rendicion = " 
            + id.ToString();

            List<String> allColumnsNew = new List<String>(allColumns);
            List<String> tiposNew = new List<String>(tipos);
            allColumnsNew.Add("nombreEmpresa");
            tiposNew.Add(Utils.Utils.STRING_TYPE);

            return obtenerPorQueryGenerica(query, allColumnsNew, tiposNew);
        }

        public List<T> findRendicion(int idEmpresa, String mes, String anio)
        {
            List<String> allColumnsNew = new List<String>(allColumns);
            List<String> tiposNew = new List<String>(tipos);
            allColumnsNew.Add("nombreEmpresa");
            tiposNew.Add(Utils.Utils.STRING_TYPE);

            String query = "select r.*, e.nombre from ROCKET_DATABASE.RENDICIONES r, ROCKET_DATABASE.EMPRESAS e where year(fecha) = "
            + anio.ToString() + " and month(fecha) = " + mes.ToString() + " and id_empresa = " + idEmpresa.ToString()
            + " and e.empresa_id = r.empresa_id";

            return this.obtenerPorQueryGenerica(query, allColumns, tipos);
        }

        public List<T> filtrarRendiciones(int idEmpresa, String mes, String anio)
        {

            if (!(mes.Equals("") && anio.Equals("") && idEmpresa == 0))
            {
                List<String> allColumnsNew = new List<String>(allColumns);
                List<String> tiposNew = new List<String>(tipos);

                String query = "";
                if (idEmpresa != 0)
                {
                    allColumnsNew.Add("nombreEmpresa");
                    tiposNew.Add(Utils.Utils.STRING_TYPE);
                    query += "select r.*, e.nombre from ROCKET_DATABASE.RENDICIONES r, ROCKET_DATABASE.EMPRESAS e ";
                }
                else
                {
                    query += "select r.* from ROCKET_DATABASE.RENDICIONES r ";
                }

                query += " where ";

                if (!anio.Equals(""))
                {
                    query += "year(fecha) = " + anio.ToString();
                    if (!mes.Equals("") || idEmpresa != 0) {
                        query += " and ";
                    }
                }
                if (!mes.Equals(""))
                {
                    query += "month(fecha) = " + mes.ToString();
                    if (idEmpresa != 0){
                        query += " and ";
                    }
                }
                if (idEmpresa != 0)
                {
                    query += "r.id_empresa = " + idEmpresa.ToString() + " and e.id_empresa = r.id_empresa ";
                }

                return this.obtenerPorQueryGenerica(query, allColumnsNew, tiposNew);
            }
            else
            {
                return new List<T>();
            }

        }
    }
}
