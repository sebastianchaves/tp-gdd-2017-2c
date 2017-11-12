using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class FormaPagoDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.FORMAS_PAGO";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public FormaPagoDAO()
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

            allColumnsInDB.Add("id_forma_pago");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("descripcion");
        }

        // Selects
        public List<T> findFormasPago()
        {
            Condicion condicion = new Condicion();

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

    }
}
