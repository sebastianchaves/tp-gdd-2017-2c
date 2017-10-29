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
        private String connectionString = "Data Source=DANIEL-PC\\SQLSERVER2012;Initial Catalog=GD2C2017;User ID=sa;Password=gestiondedatos;";
        public const String ALL = "*";
        private SqlConnection connection;

        private SqlDataReader select(String tabla, String[] parametros, String conditions)
        {
            String aplanados = "";
            for (int i = 0; i < parametros.LongLength; i++)
            {
                String parametro = parametros[i];
                aplanados += parametros[i];

                if (i < parametros.LongLength - 1)
                {
                    aplanados += ", ";
                }
            }
            //select(tabla, aplanados, conditions)
            return null;
        }

        protected List<List<String>> select(String tabla, String select, List<String> tipos, Condicion condicion) {

            using (this.connection = new SqlConnection(connectionString))
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

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        String valor="";
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
                                valor = reader.GetInt32(i).ToString();
                                break;
                            case Utils.Utils.DATETIME_TYPE:
                                valor = reader.GetDateTime(i).ToString();
                                break;
                            case Utils.Utils.DECIMAL_TYPE:
                                valor = reader.GetDecimal(i).ToString();
                                break;
                            case Utils.Utils.BINARY_TYPE:
                                SqlBinary binary = reader.GetSqlBinary(i);
                                byte[] bb = binary.Value;
                                byte bbb = bb[0];
                                Boolean boolean = Convert.ToBoolean(bbb);
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
                    else
                    {
                        where += columns.ElementAt(i) + " = " + valor;
                    }
                    if (conditions.Count > i + 1 && conditions.ElementAt(i + 1) != null && !conditions.ElementAt(i + 1).Equals("")) 
                    { 
                        where += " AND "; 
                    }
                }
            }

            return where;
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
            if (tipo.Equals(Utils.Utils.INT_TYPE))
            {
                myFieldInfo.SetValue(entidad, Int32.Parse(valor));
            }
            if (tipo.Equals(Utils.Utils.DATETIME_TYPE))
            {
                myFieldInfo.SetValue(entidad, DateTime.Parse(valor));
            }
            if (tipo.Equals(Utils.Utils.BINARY_TYPE))
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

    }
}
