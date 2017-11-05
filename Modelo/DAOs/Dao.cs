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
    class Dao<T>
    {

        private String CONNECTION_STRING = ConfigurationManager.ConnectionStrings["dataBase"].ConnectionString;
        public const String ALL = "*";
        private SqlConnection connection;

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

        private void closeConnections(SqlDataReader reader)
        {
            if (reader != null) { reader.Close(); }
            if (this.connection != null) { this.connection.Close(); }
        }

        private void closeConnections()
        {
            if (this.connection != null) { this.connection.Close(); }
        }

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

        protected int insert(String tabla, List<String> columnas, List<String> tipos, List<String> valores)
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
            insert += ") VALUES (";

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
                        insert += "convert(datetime, '" + DateTime.Parse(valores.ElementAt(i)).ToString() + "')";
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
                this.connection.Open();
                SqlCommand command = new SqlCommand(insert, connection);
                int result = command.ExecuteNonQuery();
                closeConnections();
                return result;
            }
        }

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
