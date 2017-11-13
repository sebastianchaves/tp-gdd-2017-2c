using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class RolFuncionalidadDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.ROL_FUNCIONALIDAD";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public RolFuncionalidadDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("idFuncionalidad");
            allColumns.Add("idRol");

            allColumnsInDB.Add("id_funcionalidad");
            allColumnsInDB.Add("id_rol");
        }

        // Inserts
        public void insert(RolFuncionalidad rolFuncionalidad)
        {
            List<String> valores = new List<String>();

            valores.Add(rolFuncionalidad.idFuncionalidad.ToString());
            valores.Add(rolFuncionalidad.idRol.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Delete
        public int delete(RolFuncionalidad rolFuncionalidad)
        {
            String query = "DELETE from " + TABLA + 
                " where id_funcionalidad = " + rolFuncionalidad.idFuncionalidad +
                " and id_rol = " + rolFuncionalidad.idRol;

            return deleteQuery(query);
        }

    }
}
