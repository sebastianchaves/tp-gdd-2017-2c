﻿using PagoAgilFrba.Model;
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

    class ClienteDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.CLIENTES";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public ClienteDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            /**
            * Tipos de columnas en la tabla de la base de datos
            * ID_NOT_INSERTABLE: Es para especificar que este tipo de dato, no va en el insert porque es un ID
            * generado por la base de datos. **/
            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.DATETIME_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);

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

            //Nombre de columnas en la tabla de base de datos. (no siempre coinciden con los fields de la clase)
            allColumnsInDB.Add("id");
            allColumnsInDB.Add("dni");
            allColumnsInDB.Add("apellido");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("fecha_nac");
            allColumnsInDB.Add("mail");
            allColumnsInDB.Add("direccion");
            allColumnsInDB.Add("codigo_postal");
            allColumnsInDB.Add("telefono");
            allColumnsInDB.Add("habilitado");
        }

        // Inserts
        public void agregarCliente(Cliente cliente)
        {
            List<String> valores = new List<String>();
            //Hay que agregar los valores de todas las columnas, respetando ese orden
            //El id va nulo, igual no importa porque no se inserta. (lo calcula la base automaticamente)
            valores.Add("");
            valores.Add(cliente.dni.ToString());
            valores.Add(cliente.apellido);
            valores.Add(cliente.nombre);
            valores.Add(cliente.fechaDeNacimiento.ToString());
            valores.Add(cliente.mail);
            valores.Add(cliente.direccion);
            valores.Add(cliente.codigoPostal);
            valores.Add(cliente.telefono);
            valores.Add(cliente.habilitado.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Selects
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

        // Busca clientes y devuelve uno solo por id
        public T findClienteById(String id)
        {
            String query = "SELECT * from " + TABLA + " where id_cliente = " + id;
            return obtenerPorQueryGenerica(query, allColumns, tipos).ElementAt(0);
        }

        // realiza el update de un cliente
        public void updateCliente(Cliente clienteUpdate)
        {
            Condicion actualizacion = new Condicion();
            actualizacion.agregarCondicion("dni", clienteUpdate.dni, Utils.Utils.INT_TYPE);
            actualizacion.agregarCondicion("apellido", clienteUpdate.apellido, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("nombre", clienteUpdate.nombre, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("fecha_nac", clienteUpdate.fechaDeNacimiento, Utils.Utils.DATETIME_TYPE);
            actualizacion.agregarCondicion("mail", clienteUpdate.mail, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("direccion", clienteUpdate.direccion, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("codigo_postal", clienteUpdate.codigoPostal, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("telefono", clienteUpdate.telefono, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("habilitado", clienteUpdate.habilitado.ToString(), Utils.Utils.BIT_TYPE);
            
            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_cliente", clienteUpdate.id, Utils.Utils.INT_TYPE);
           
            update(TABLA, actualizacion, condicion);
        }

        public bool existeMail(String mail)
        {
            String query = "SELECT * from " + TABLA + " where mail = '" + mail + "'";
            List<T> lista = obtenerPorQueryGenerica(query, allColumns, tipos);
            return lista.Count > 0;
        }
    }
}
