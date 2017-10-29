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
        private List<String> tipos;

        public Condicion()
        {
            columns = new List<String>();
            conditions = new List<String>();
            tipos = new List<String>();
        }

        public void agregarCondicion(String columna, String condicion, String tipo)
        {
            columns.Add(columna);
            conditions.Add(condicion);
            tipos.Add(tipo);
        }

        public void agregarCondicion(String columna, int condicion, String tipo)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
            tipos.Add(tipo);
        }

        public void agregarCondicion(String columna, decimal condicion, String tipo)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
            tipos.Add(tipo);
        }

        public void agregarCondicion(String columna, DateTime condicion, String tipo)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
            tipos.Add(tipo);
        }

        public void agregarCondicion(String columna, SqlBinary condicion, String tipo)
        {
            columns.Add(columna);
            conditions.Add(condicion.ToString());
            tipos.Add(tipo);
        }

        public List<String> getColumns()
        {
            return columns;
        }

        public List<String> getConditions()
        {
            return conditions;
        }

        public List<String> getTipos()
        {
            return tipos;
        }
    }
}
