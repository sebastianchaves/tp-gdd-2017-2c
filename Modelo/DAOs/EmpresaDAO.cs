﻿using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class EmpresaDAO<T>: Dao<T>
    {

        private const String RENDICION_STORED_PROCEDURE = "[ROCKET_DATABASE].rendirEmpresa";
        private const String EMPRESAS = "GD2C2017.ROCKET_DATABASE.EMPRESAS";
        private const String RUBROS = "GD2C2017.ROCKET_DATABASE.RUBROS";
        private const String PUEDE_DESHABILITAR = "select count(1) from rocket_database.facturas f, "+
            "rocket_database.pago_factura pf where pf.id_factura = f.id_Factura and f.id_rendicion is null "+
            "AND id_empresa = ";
        private const String EMPRESAS_POR_DIA_DE_RENDICION = "select * from rocket_Database.empresas where dia_de_rendicion = ";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public EmpresaDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("id");
            allColumns.Add("cuit");
            allColumns.Add("nombre");
            allColumns.Add("direccion");
            allColumns.Add("idRubro");
            allColumns.Add("activo");
            allColumns.Add("diaDeRendicion");

            allColumnsInDB.Add("id_empresa");
            allColumnsInDB.Add("cuit");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("direccion");
            allColumnsInDB.Add("id_rubro");
            allColumnsInDB.Add("activo");
            allColumnsInDB.Add("dia_de_rendicion");
        }

        // Inserts
        public void agregarEmpresa(Empresa empresa)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(empresa.cuit);
            valores.Add(empresa.nombre);
            valores.Add(empresa.direccion);
            valores.Add(empresa.idRubro.ToString());
            valores.Add(empresa.activo.ToString());
            valores.Add(empresa.diaDeRendicion.ToString());

            insert(EMPRESAS, allColumnsInDB, tipos, valores);
        }

        // Selects
        public List<T> findEmpresas()
        {
            Condicion condicion = new Condicion();

            List<List<String>> resultSet = this.select(EMPRESAS, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        // Busca empresa por nombre, cuit y rubro. Pueden ser nulos.
        public List<T> findEmpresa(String nombreEmpresa, String cuitEmpresa, String rubroEmpresa)
        {
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("e.nombre", nombreEmpresa, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("e.cuit", cuitEmpresa, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("r.nombre", rubroEmpresa, Utils.Utils.STRING_TYPE);

            List<List<String>> resultSet = this.select(EMPRESAS + " e, " + RUBROS + " r", ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }
        // busca una empresa por id.
        public T findEmpresaById(String id)
        {
            String query = "SELECT * from " + EMPRESAS + " where id_empresa = " + id;
            return obtenerPorQueryGenerica(query, allColumns, tipos).ElementAt(0);
        }

        // Updates
        public void updateEmpresa(Empresa empresaUpdate)
        {
            Condicion actualizacion = new Condicion();
            actualizacion.agregarCondicion("cuit", empresaUpdate.cuit, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("nombre", empresaUpdate.nombre, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("direccion", empresaUpdate.direccion, Utils.Utils.STRING_TYPE);
            actualizacion.agregarCondicion("id_rubro", empresaUpdate.idRubro, Utils.Utils.INT_TYPE);
            actualizacion.agregarCondicion("activo", empresaUpdate.activo.ToString(), Utils.Utils.BIT_TYPE);
            actualizacion.agregarCondicion("dia_de_rendicion", empresaUpdate.diaDeRendicion, Utils.Utils.INT_TYPE);

            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_empresa", empresaUpdate.id, Utils.Utils.INT_TYPE);

            update(EMPRESAS, actualizacion, condicion);
        }
        //Devuelve true si la empresa espeficidada se puede deshabilitar (valida que no tenga facturas por rendir)
        public Boolean puedeDeshabilitar(Empresa empresaUpdate)
        {
            int count = obtenerCountQueryGenerica(PUEDE_DESHABILITAR + empresaUpdate.id);
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Devuelve una lista de empresas que rinden en el dia especificado
        public List<T> obtenerEmpresasPorDiaDeRendicion(int dia)
        {
            return obtenerPorQueryGenerica(EMPRESAS_POR_DIA_DE_RENDICION + dia.ToString(), allColumns, tipos);
        }
        //Rinde la empresa indicada, en el anio, mes y dia, con el porcentaje de comision especificado.
        //Utiliza un stored procedure para esto
        public int rendirEmpresa(int idEmpresa, int anio, int mes, int dia, decimal porcentaje)
        {
            using (this.connection = new SqlConnection(CONNECTION_STRING))
            {
                this.connection.Open();
                SqlCommand command = new SqlCommand(RENDICION_STORED_PROCEDURE, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_empresa", idEmpresa);
                command.Parameters.AddWithValue("@mes", mes);
                command.Parameters.AddWithValue("@dia", dia);
                command.Parameters.AddWithValue("@anio", anio);
                command.Parameters.AddWithValue("@porcentaje", porcentaje);
                var returnParameter = command.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                var result = returnParameter.Value;
                closeConnections();
                return Int32.Parse(result.ToString());
            }
        }
    }
}
