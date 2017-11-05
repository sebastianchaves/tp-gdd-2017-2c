using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class UsuarioDAO<T> : Dao<T>
    {
        private const String TABLA = "GD2C2017.ROCKET_DATABASE.USUARIOS";
        private const String SETEAR_INTENTOS = "";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public UsuarioDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("apellido");
            allColumns.Add("contrasenia");
            allColumns.Add("idSucursal");
            allColumns.Add("intentos");
            allColumns.Add("habilitado");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("apellido");
            allColumnsInDB.Add("contrasenia");
            allColumnsInDB.Add("id_sucursal");
            allColumnsInDB.Add("intentos");
            allColumnsInDB.Add("habilitado");
        }

        // Selects
        public List<T> findUsuario(string nombreUsuario)
        {
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("nombre", nombreUsuario, Utils.Utils.STRING_TYPE);

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        public int sumarIntentos(Usuario usuario)
        {
            Condicion actualizacion = new Condicion();
            actualizacion.agregarCondicion("intentos", usuario.intentos + 1, Utils.Utils.INT_TYPE);
            if (usuario.intentos == 2)
            {
                actualizacion.agregarCondicion("habilitado", Boolean.FalseString, Utils.Utils.BIT_TYPE);
            }
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("id_usuario", usuario.id, Utils.Utils.INT_TYPE);
            update(TABLA, actualizacion, condicion);
            return usuario.intentos + 1;
        }

        public void reiniciarIntentos(Usuario usuario)
        {
            Condicion actualizacion = new Condicion();
            actualizacion.agregarCondicion("intentos", 0, Utils.Utils.INT_TYPE);
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("id_usuario", usuario.id, Utils.Utils.INT_TYPE);
            update(TABLA, actualizacion, condicion);
        }
    }
}
