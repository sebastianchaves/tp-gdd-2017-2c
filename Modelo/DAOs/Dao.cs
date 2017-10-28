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

        public static const string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["dataBase"].ConnectionString;
        public static const String ALL = "*";
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
            return select(tabla, aplanados, conditions);
        }

        public SqlDataReader select(String tabla, String parametros, String conditions) {

            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {
                String selectQuery = "SELECT " + parametros + " FROM " + tabla + " WHERE " + conditions;

                SqlCommand command = new SqlCommand(selectQuery, connection);
                
                this.connection.Open();

                return command.ExecuteReader();
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

            for(int i = 0; i < columns.Count; i++)
            {
                String column = columns.ElementAt(i);

                if (column != null)
                {
                    where += column + " = " + conditions.ElementAt(i);
                    if (columns.Count > i + 1 && columns.ElementAt(i + 1) != null) { where += " AND "; }
                }
            }

            return where;
        }

    }
}
