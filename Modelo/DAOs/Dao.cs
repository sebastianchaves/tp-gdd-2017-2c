using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    /**
     * Clase padre de todos los DAOS de la aplicacion. Provee la funcionalidad generica y repetida en todos los DAOS.
     * Es una clase tipada, es decir que todos los metodos desarrollados aqui, tienen en cuenta el tipo de Entidad
     * para la cual fue definida. Todos los metodos son usados por sus clases hijas, ya que esta es una clase abstracta
     * y no puede ser instanciada.
     */ 
    abstract class Dao<T>
    {

        protected String CONNECTION_STRING = ConfigurationManager.ConnectionStrings["dataBase"].ConnectionString;
        public const String ALL = "*";
        protected SqlConnection connection;

        /**
         * Metodo que dada una tabla, una seleccion de columnas, los tipos de las columnas y una lista de condiciones
         * en el where arma una query, y la ejecuta en la base de datos. Luego arma una lista de listas de String,
         * dicha estructura son los registros devueltos por la base de datos con sus columnas.
         * Este metodo es usado de manera generica por todos los DAOS de la aplicacion que hereden de esta clase.
         */
        protected List<List<String>> select(String tabla, String select, List<String> tipos, Condicion condicion)
        {

            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {
                String selectQuery = "SELECT " + select + " FROM " + tabla;
                String condicionString = armarWhere(condicion.getColumns(), condicion.getConditions(), condicion.getTipos());

                if (condicionString != null && !condicionString.Equals(""))
                {
                    selectQuery += " WHERE " + condicionString;
                }

                this.connection.Open();

                SqlCommand command = new SqlCommand(selectQuery, connection);

                SqlDataReader reader = command.ExecuteReader();
                List<List<String>> resultSet = new List<List<String>>();

                while (reader.Read())
                {
                    List<String> registro = new List<string>();

                    for (int i = 0; i < tipos.Count; i++)
                    {
                        String valor = "";
                        switch (tipos.ElementAt(i))
                        {
                            case Utils.Utils.STRING_TYPE:
                                if (!reader.IsDBNull(i))
                                {
                                    valor = reader.GetString(i);
                                }
                                else
                                {
                                    valor = "";
                                }
                                break;
                            case Utils.Utils.INT_TYPE:
                                if (!reader.IsDBNull(i))
                                {
                                    valor = reader.GetInt32(i).ToString();
                                }
                                else
                                {
                                    valor = "0";
                                }
                                break;
                            case Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE:
                                valor = reader.GetInt32(i).ToString();
                                break;
                            case Utils.Utils.DATETIME_TYPE:
                                valor = reader.GetDateTime(i).ToString();
                                break;
                            case Utils.Utils.DECIMAL_TYPE:
                                valor = reader.GetDecimal(i).ToString();
                                break;
                            case Utils.Utils.BIT_TYPE:
                                Boolean boolean = reader.GetBoolean(i);
                                valor = boolean.ToString();
                                break;
                        }
                        registro.Add(valor);
                    }
                    resultSet.Add(registro);
                }
                closeConnections(reader);
                return resultSet;

            }

        }

        /*
         * Metodo que cierra la conexion de base de datos y el objecto SqlDataReader. Es usado por los DAOS que heredan
         * de esta clase.
         */
        protected void closeConnections(SqlDataReader reader)
        {
            if (reader != null) { reader.Close(); }
            if (this.connection != null) { this.connection.Close(); }
        }
        /*
         * Metodo sobrecargado que solo cierra la conexion. Es usado por los DAOS que heredan de esta clase
         */ 
        protected void closeConnections()
        {
            if (this.connection != null) { this.connection.Close(); }
        }

        /**
         * Metodo privado que dada una lista de columnas, condiciones y tipos, arma la sintaxis del where
         * en una consulta SQL. Es usado indistintamente para select o update.
         */ 
        private String armarWhere(List<String> columns, List<String> conditions, List<String> tipos)
        {
            String where = "";

            for (int i = 0; i < conditions.Count; i++)
            {
                String valor = conditions.ElementAt(i);

                if (valor != null && !valor.Equals(""))
                {
                    if (tipos.ElementAt(i).Equals(Utils.Utils.STRING_TYPE))
                    {
                        where += columns.ElementAt(i) + " = '" + valor + "'";
                    }
                    else if (tipos.ElementAt(i).Equals(Utils.Utils.BIT_TYPE))
                    {
                        where += columns.ElementAt(i) + " = " + valor;
                    }
                    else
                    {
                        where += columns.ElementAt(i) + " = " + valor;
                    }
                    if (hayMasElementosNoNulos(conditions, i))
                    {
                        where += " AND ";
                    }
                }
            }

            return where;
        }

        /**
         * Metodo utilitario para verificar que hay mas condiciones para agregar, entonces puede tomar la decision
         * de agregar una , en el insert/update o un AND en el select.
         * */
        private Boolean hayMasElementosNoNulos(List<String> conditions, int i)
        {
            for (int a = i + 1; a < conditions.Count; a++)
            {
                if (conditions.ElementAt(a) != null && !conditions.ElementAt(a).Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

        /**
         * Metodo que dado un tipo INT, STRING, DATE, etc y dado un FieldInfo perteneciente a una instancia de clase,
         * setea el field. (Para cada tipo de datos se requieren algunas particularidades al momento de setear)
         */ 
        protected void setWithType(FieldInfo myFieldInfo, Object entidad, String valor, String tipo)
        {
            if (tipo.Equals(Utils.Utils.STRING_TYPE))
            {
                myFieldInfo.SetValue(entidad, valor);
            }
            if (tipo.Equals(Utils.Utils.DECIMAL_TYPE))
            {
                myFieldInfo.SetValue(entidad, Decimal.Parse(valor));
            }
            if (tipo.Equals(Utils.Utils.INT_TYPE) || tipo.Equals(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE))
            {
                myFieldInfo.SetValue(entidad, Int32.Parse(valor));
            }
            if (tipo.Equals(Utils.Utils.DATETIME_TYPE))
            {
                myFieldInfo.SetValue(entidad, DateTime.Parse(valor));
            }
            if (tipo.Equals(Utils.Utils.BIT_TYPE))
            {
                myFieldInfo.SetValue(entidad, Boolean.Parse(valor));
            }
        }

        /**
         * Metodo que, dado un resultset (filas y columnas de resultado de una query de seleccion), dada una
         * lista de de nombres de fields de entidades y sus respectivos tipos, genera las entidades para el cual el
         * DAO fue tipado. Esto lo realiza de manera generica indistintamente de que entidad se trate.
         */ 
        protected List<T> getEntities(List<List<String>> resultSet, List<String> allColumns, List<String> tipos)
        {
            List<T> entities = new List<T>();
            Type myType = typeof(T);
            using (IEnumerator<List<String>> enumerator = resultSet.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    List<String> item = enumerator.Current;
                    ConstructorInfo ctor = myType.GetConstructor(Type.EmptyTypes);
                    object entityObj = ctor.Invoke(new object[] { });
                    T entity = (T)entityObj;
                    int a = 0;

                    using (IEnumerator<String> enumerator2 = allColumns.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            String column = enumerator2.Current;
                            FieldInfo myFieldInfo = myType.GetField(column);
                            setWithType(myFieldInfo, entity, item.ElementAt(a), tipos.ElementAt(a));
                            a++;
                        }
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }

        /**
         * Sobrecarga del metodo de insert para cuando no se especifica si el mismo retorna un valor escalar.
         * Por default, sino especifica, entonces no devuelve un escalar
         */ 
        protected int insert(String tabla, List<String> columnas, List<String> tipos, List<String> valores)
        {
            return this.insert(tabla, columnas, tipos, valores, false);
        }

        /**
         * Metodo que dada una lista de columnas de base de datos, sus tipos y sus valores, arma genericamente una
         * query de insercion. El valor output indica si el insert devuelve un escalar luego de la insercion o no.
         */ 
        protected int insert(String tabla, List<String> columnas, List<String> tipos, List<String> valores, bool output)
        {
            String insert = "INSERT INTO " + tabla + "(";
            for (int i = 0; i < columnas.Count; i++)
            {
                if (!tipos.ElementAt(i).Equals(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE))
                {
                    insert += columnas.ElementAt(i);
                    if (i + 1 < columnas.Count && !tipos.ElementAt(i + 1).Equals(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE))
                    {
                        insert += ", ";
                    }
                }
            }

            if (output)
            {
                insert += ") OUTPUT INSERTED." + columnas.ElementAt(0) + " VALUES (";
            }
            else
            {
                insert += ") VALUES (";
            }

            for (int i = 0; i < columnas.Count; i++)
            {
                if (!tipos.ElementAt(i).Equals(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE))
                {
                    if (tipos.ElementAt(i).Equals(Utils.Utils.STRING_TYPE))
                    {
                        insert += "'" + valores.ElementAt(i) + "'";
                    }
                    else if (tipos.ElementAt(i).Equals(Utils.Utils.DATETIME_TYPE))
                    {
                        insert += "convert(datetime, '" + valores.ElementAt(i) + "')";
                        // DateTime.Parse(valores.ElementAt(i)).ToString()
                    }
                    else if (tipos.ElementAt(i).Equals(Utils.Utils.BIT_TYPE))
                    {
                        Boolean b = Boolean.Parse(valores.ElementAt(i));
                        if (b)
                        {
                            insert += "1";
                        }
                        else
                        {
                            insert += "0";
                        }
                    }
                    else if (tipos.ElementAt(i).Equals(Utils.Utils.DECIMAL_TYPE))
                    {
                        insert += "'" + valores.ElementAt(i).Replace(",", ".") + "'";
                    }
                    else
                    {
                        insert += valores.ElementAt(i);
                    }
                    if (i + 1 < columnas.Count && !tipos.ElementAt(i + 1).Equals(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE))
                    {
                        insert += ", ";
                    }
                }
            }
            insert += ") ";
            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {
                int result;
                this.connection.Open();
                SqlCommand command = new SqlCommand(insert, connection);

                if (!output)
                {
                    result = command.ExecuteNonQuery();
                }
                else
                {
                    result = (int)command.ExecuteScalar();
                }

                closeConnections();
                return result;
            }
        }

        /**
         * Metodo que dada una tabla, una lista de actualizaciones y una condicion de where arma una query genericamente
         * de update en la tabla especificada.
         */
        public int update(String tabla, Condicion actualizacion, Condicion condicion)
        {
            if (hayMasElementosNoNulos(actualizacion.getConditions(), -1))
            {
                String updateString = "update " + tabla + " set ";
                for (int i = 0; i < actualizacion.getColumns().Count; i++)
                {
                    String columna = actualizacion.getColumns().ElementAt(i);
                    String valor = actualizacion.getConditions().ElementAt(i);
                    String tipo = actualizacion.getTipos().ElementAt(i);
                    if (valor != null && !valor.Equals(""))
                    {
                        if (tipo.Equals(Utils.Utils.STRING_TYPE))
                        {
                            updateString += columna + " = '" + valor + "'";
                        }
                        else if (tipo.Equals(Utils.Utils.DATETIME_TYPE))
                        {
                            updateString += columna + " = convert(datetime, '" + valor + "')";
                        }
                        else if (tipo.Equals(Utils.Utils.BIT_TYPE))
                        {
                            if (Boolean.TrueString.Equals(valor))
                            {
                                updateString += columna + " = 1";
                            }
                            else
                            {
                                updateString += columna + " = 0";
                            }
                        }
                        else if (tipo.Equals(Utils.Utils.DECIMAL_TYPE))
                        {
                            updateString += columna + " = '" + valor.Replace(",", ".") + "'";
                        }
                        else
                        {
                            updateString += columna + " = " + valor;
                        }
                    }
                    if (valor != null && !valor.Equals("") && hayMasElementosNoNulos(actualizacion.getConditions(), i))
                    {
                        updateString += ", ";
                    }
                }
                if (hayMasElementosNoNulos(condicion.getConditions(), -1))
                {
                    updateString += " where " + armarWhere(condicion.getColumns(), condicion.getConditions(), condicion.getTipos());
                }
                using (this.connection = new SqlConnection(CONNECTION_STRING))
                {
                    this.connection.Open();
                    SqlCommand command = new SqlCommand(updateString, connection);
                    int result = command.ExecuteNonQuery();
                    closeConnections();
                    return result;
                }
            }
            return -1;
        }

        /**
         * Metodo que, dada una query cualquiera, y la lista de nombres de columnas del select y sus tipos, arma
         * una query, la ejecuta y luego devuelve las entidades para el cual el DAO fue tipado con los resultados de la query.
         * */
        protected List<T> obtenerPorQueryGenerica(String query, List<String> allColumns, List<String> tipos)
        {
            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {

                this.connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                List<List<String>> resultSet = new List<List<String>>();

                while (reader.Read())
                {
                    List<String> registro = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        String valor = "";
                        switch (tipos.ElementAt(i))
                        {
                            case Utils.Utils.STRING_TYPE:
                                if (!reader.IsDBNull(i))
                                {
                                    valor = reader.GetString(i);
                                }
                                else
                                {
                                    valor = "";
                                }
                                break;
                            case Utils.Utils.INT_TYPE:
                                if (!reader.IsDBNull(i))
                                {
                                    valor = reader.GetInt32(i).ToString();
                                }
                                else
                                {
                                    valor = "0";
                                }
                                break;
                            case Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE:
                                valor = reader.GetInt32(i).ToString();
                                break;
                            case Utils.Utils.DATETIME_TYPE:
                                valor = reader.GetDateTime(i).ToString();
                                break;
                            case Utils.Utils.DECIMAL_TYPE:
                                decimal d = reader.GetDecimal(i);
                                valor = d.ToString();
                                break;
                            case Utils.Utils.BIT_TYPE:
                                Boolean boolean = reader.GetBoolean(i);
                                valor = boolean.ToString();
                                break;
                        }
                        registro.Add(valor);
                    }
                    resultSet.Add(registro);
                }
                closeConnections(reader);
                return getEntities(resultSet, allColumns, tipos);
            }
        }
        /**
         * Metodo que dado una query cualquiera, la ejecuta en la base de datos esperando como respuesta un escalar
         */ 
        protected int obtenerCountQueryGenerica(String query)
        {
            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {

                this.connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int result = (Int32)command.ExecuteScalar();
                closeConnections();
                return result;
            }
        }
        /*
         * Metodo que ejecuta cualquier query provista. Se utiliza para algunos deletes especificos. Devuelve el escalar
         * devuelto por la base de datos
         */ 
        protected int deleteQuery(String query)
        {
            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {

                this.connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int result = command.ExecuteNonQuery();
                closeConnections();
                return result;
            }
        }
    }
}
