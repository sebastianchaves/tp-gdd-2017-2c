using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    // TODO agregarCliente, existeDni, existeMail
    class ClienteDAO<T> : Dao<T>
    {

        // Atributos
        private const String TABLA = "GD2C2017.ROCKET_DATABASE.CLIENTES";
        private List<String> tipos;
        private List<String> allColumns;

        public ClienteDAO()
        {
            
            this.tipos = new List<String>();
            this.allColumns = new List<String>();

            //Tipos de columnas en la tabla de la base de datos
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.BINARY_TYPE);

            //Nombres de fields de la entity Cliente.cs. Deben coincidir uno a uno con los tipos y estar ordenado
            allColumns.Add("id");
            allColumns.Add("dni");
            allColumns.Add("apellido");
            allColumns.Add("nombre");
            allColumns.Add("fechaDeNacimiento");
            allColumns.Add("mail");
            allColumns.Add("direccion");
            allColumns.Add("codigoPostal");
            allColumns.Add("telefono");
            allColumns.Add("habilitado");

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
        public List<T> findCliente(string nombreCliente, string apellidoCliente, int dni)
        {
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("nombre", nombreCliente, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("apellido", apellidoCliente, Utils.Utils.STRING_TYPE);
            if (dni != 0)
            {
                condicion.agregarCondicion("dni", dni, Utils.Utils.INT_TYPE);
            }

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        // Updates
        public void updateCliente(Cliente clienteUpdate)
        {

        }

    }
}
