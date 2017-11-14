using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    /**
     * Clase que gestiona las condiciones de las querys genericas que realizan los daos.
     * La estructura es la siguiente: tiene tres listas con la misma cantidad de elementos que se corresponden uno a uno.
     * En la primer lista estan las columnas a actualizar/filtrar, en la segunda los valores por/a los cuales se va a 
     * seleccionar/actualizar. Y de cada uno de estas selecciones/actualizaciones estan los tipos de datos, ya que
     * no es lo mismo actualizar un string, que un int, que una fecha.
     */ 
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
            conditions.Add(String.Format("{0:yyyy-MM-dd HH:mm:ss}", condicion));
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
