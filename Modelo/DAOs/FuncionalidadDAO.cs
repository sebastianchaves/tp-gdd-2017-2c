using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class FuncionalidadDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.FUNCIONALIDADES";
        private const String FUNCIONALIDADES_POR_ROL = "select f.* from ROCKET_DATABASE.ROLES r, ROCKET_DATABASE.ROL_FUNCIONALIDAD rf, ROCKET_DATABASE.FUNCIONALIDADES f where r.id_rol = rf.id_rol and rf.id_funcionalidad = f.id_funcionalidad and r.nombre = ";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public FuncionalidadDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("descripcion");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("descripcion");
        }

        // Selects
        public List<T> findFuncionalidades()
        {
            Condicion condicion = new Condicion();

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        public List<T> obtenerFuncionalidadesPorUsuario(String usuario)
        {
            return obtenerPorQueryGenerica(
                FUNCIONALIDADES_POR_ROL + "'" + usuario + "'", allColumns, tipos);

        }

    }
}
