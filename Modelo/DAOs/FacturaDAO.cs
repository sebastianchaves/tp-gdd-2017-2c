using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class FacturaDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.FACTURAS";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public FacturaDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("id");
            allColumns.Add("dni");
            allColumns.Add("apellido");
            allColumns.Add("nombre");
            allColumns.Add("fechaDeNacimiento");
            allColumns.Add("mail");
            allColumns.Add("direccion");
            allColumns.Add("codigoPostal");
            allColumns.Add("telefono");
            allColumns.Add("habilitado");

            //Nombre de columnas en la tabla de base de datos. (no siempre coinciden con los fields de la clase)
            allColumnsInDB.Add("id");
            allColumnsInDB.Add("dni");
            allColumnsInDB.Add("apellido");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("fecha_nac");
            allColumnsInDB.Add("mail");
            allColumnsInDB.Add("direccion");
            allColumnsInDB.Add("codigo_postal");
            allColumnsInDB.Add("telefono");
            allColumnsInDB.Add("habilitado");
        }

    }
}
