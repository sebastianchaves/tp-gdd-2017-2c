using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class Dao
    {

        private String CONNECTION_STRING = ConfigurationManager.ConnectionStrings["dataBase"].ConnectionString;
        public const String ALL = "*";
        private SqlConnection connection;

        public SqlDataReader select(String tabla, String[] parametros, String conditions)
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

        protected List<List<String>> select(String tabla, String select, List<String> tipos, String conditions) {

            String connectionString = "Data Source=DESKTOP-PD7Q1R0\\SQLSERVER2012;Initial Catalog=GD2C2017;User ID=gd;Password=gd2017;";

            using (this.connection = new SqlConnection(connectionString))
            {
                String selectQuery = "SELECT " + select + " FROM " + tabla;

                if (conditions != null && !conditions.Equals(""))
                {
                    selectQuery += " WHERE " + conditions;
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
                                valor = reader.GetString(i);
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
                                valor = reader.GetSqlBinary(i).ToString();
                                break;
                        }
                        registro.Add(valor);
                    }
                    resultSet.Add(registro);
                }

                return resultSet;

            }

        }

        public void closeConnections(SqlDataReader reader)
        {
            if (reader != null) { reader.Close(); }
            if (this.connection != null) { this.connection.Close(); }
        }

        public String armarWhere(List<String> columns, List<String> conditions)
        {
            String where = "";

            for (int i = 0; i < conditions.Count; i++)
            {
                String valor = conditions.ElementAt(i);

                if (valor != null && !valor.Equals(""))
                {
                    where += columns.ElementAt(i) + " = " + valor;
                    if (conditions.Count > i + 1 && conditions.ElementAt(i + 1) != null && !conditions.ElementAt(i + 1).Equals("")) 
                    { 
                        where += " AND "; 
                    }
                }
            }

            return where;
        }

    }
}
