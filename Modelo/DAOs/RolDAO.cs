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
        private const String ROLES_X_USUARIO = "select r.* from ROCKET_DATABASE.ROLES r, ROCKET_DATABASE.USUARIOS u, ROCKET_DATABASE.USUARIO_ROLES ur where r.id_rol = ur.id_rol and ur.id_usuario = u.id_usuario and u.nombre = ";
        private const String INHABILITAR_ROLES_USUARIO = "delete from rocket_database.usuario_roles where id_rol = ";
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

            allColumnsInDB.Add("id_rol");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("descripcion");
            allColumnsInDB.Add("habilitado");
        }

        // Inserts
        public int agregarRol(Rol rol)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(rol.nombre);
            valores.Add(rol.descripcion);
            valores.Add(rol.habilitado.ToString());

            return insert(TABLA, allColumnsInDB, tipos, valores, true);
        }

        // Selects
        public List<T> findRol()
        {
            Condicion condicion = new Condicion();

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        public List<T> findRol(Rol rol)
        {
            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_rol", rol.id, Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        public List<T> obtenerRolesPorUsuario(String usuario)
        {
            return obtenerPorQueryGenerica(ROLES_X_USUARIO + "'" + usuario + "'", allColumns, tipos);
        }

        // Updates
        public void updateRol(Rol rolUpdate)
        {
            Condicion actualizacion = new Condicion();

            actualizacion.agregarCondicion("nombre", rolUpdate.nombre, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("descripcion", rolUpdate.descripcion, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("habilitado", rolUpdate.habilitado.ToString(), Utils.Utils.BIT_TYPE);

            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_rol", rolUpdate.id, Utils.Utils.INT_TYPE);

            update(TABLA, actualizacion, condicion);
        }

        public void darDeBajaRolEnTodosLosUsuarios(Rol rol)
        {
            deleteQuery(INHABILITAR_ROLES_USUARIO + rol.id);
        }
    }
}
