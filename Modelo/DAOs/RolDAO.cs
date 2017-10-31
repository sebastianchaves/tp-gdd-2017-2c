using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class RolDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.ROLES";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public RolDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("descripcion");
            allColumns.Add("habilitado");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("descripcion");
            allColumnsInDB.Add("habilitado");
        }

        // Inserts
        public void agregarRol(Rol rol)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(rol.nombre);
            valores.Add(rol.descripcion);
            valores.Add(rol.habilitado.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

    }
}
