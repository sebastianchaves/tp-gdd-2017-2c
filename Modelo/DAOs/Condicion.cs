using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    public class Condicion
    {
        private List<String> columns;
        private List<String> conditions;

        public Condicion()
        {
            columns = new List<String>();
            conditions = new List<String>();
        }

        public void agregarCondicion(String columna, String condicion)
        {
            columns.Add(columna);
            conditions.Add(condicion);
        }

        public void agregarCondicion(String columna, int condicion)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
        }

        public void agregarCondicion(String columna, decimal condicion)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
        }

        public void agregarCondicion(String columna, DateTime condicion)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
        }

        public void agregarCondicion(String columna, SqlBinary condicion)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
        }

        public List<String> getColumns()
        {
            return columns;
        }

        public List<String> getConditions()
        {
            return conditions;
        }
    }
}
