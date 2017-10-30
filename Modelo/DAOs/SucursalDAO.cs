﻿using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class SucursalDAO<T> : Dao<T>
    {

        private const String TABLA = "GD2C2017.ROCKET_DATABASE.SUCURSALES";
        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public SucursalDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_ID_NOT_INSERTABLE_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.BIT_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("direccion");
            allColumns.Add("codigoPostal");
            allColumns.Add("activo");

            allColumnsInDB.Add("id");
            allColumnsInDB.Add("nombre");
            allColumnsInDB.Add("direccion");
            allColumnsInDB.Add("codigo_postal");
            allColumnsInDB.Add("activo");
        }

        // Inserts
        public void agregarSucursal(Sucursal sucursal)
        {
            List<String> valores = new List<String>();

            valores.Add("");
            valores.Add(sucursal.nombre);
            valores.Add(sucursal.direccion);
            valores.Add(sucursal.codigoPostal);
            valores.Add(sucursal.activo.ToString());

            insert(TABLA, allColumnsInDB, tipos, valores);
        }

        // Selects
        public List<T> findSucursal(String nombreSucursal, String direccionSucursal, String codigoPostalSucursal)
        {
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("nombre", nombreSucursal, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("direccion", direccionSucursal, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("codigo_postal", codigoPostalSucursal, Utils.Utils.STRING_TYPE);

            List<List<String>> resultSet = this.select(TABLA, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        // Updates
        public void updateSucursal(Sucursal sucursalModificada)
        {

        }

    }
}
