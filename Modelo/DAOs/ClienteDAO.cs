using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    // TODO agregarCliente, existeDni, existeMail
    class ClienteDAO : Dao
    {

        // Atributos
        private const String TABLA = "GD2C2017.ROCKET_DATABASE.CLIENTES";
        private List<String> mapaCliente;

        public ClienteDAO()
        {
            this.mapaCliente = new List<String>();

            mapaCliente.Add(Utils.Utils.INT_TYPE);
            mapaCliente.Add(Utils.Utils.INT_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.DATETIME_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.STRING_TYPE);
            mapaCliente.Add(Utils.Utils.BINARY_TYPE);
        }

        // Adds
        public void agregarCliente(Cliente cliente)
        { 

        }

        // Exists
        public Boolean existeDni(int dni)
        {
            return false;
        }

        public Boolean existeMail(String mail)
        {
            return false;
        }

        // Finds
        public List<Cliente> findCliente(string nombreCliente, string apellidoCliente, int dni)
        {
            List<String> columns = new List<String>();
            List<String> conditions = new List<String>();

            columns.Add("nombre");
            columns.Add("apellido");
            columns.Add("dni");
            
            conditions.Add(nombreCliente);
            conditions.Add(nombreCliente);
            conditions.Add(dni.ToString());

            List<List<String>> resultSet = this.select(TABLA, ALL, this.mapaCliente, this.armarWhere(columns, conditions));



            return null;
        }

        // Updates
        public void updateCliente(Cliente clienteUpdate)
        {

        }

    }
}
