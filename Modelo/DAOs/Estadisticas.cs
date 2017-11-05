using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class PorcentajeFacturasPagadasDao<T> : Dao<T>
    {
        private const String FECHA_INICIO = "#FECHA_INICIO#";
        private const String FECHA_FIN = "#FECHA_FIN#";
        private const String PORCENTAJE_PAGADO =
            "select top 5 id_empresa, nombre, ( " +
            "(select count(distinct f.nro_factura) from rocket_Database.facturas f, rocket_Database.pago_factura pf " +
            "where f.id_empresa = id_empresa and f.id_factura = pf.id_factura and f.fecha_alta > convert(datetime, '" + FECHA_INICIO + "') " +
            "and f.fecha_alta < convert(datetime, '"+ FECHA_FIN +"')) * 100 / " +
            "(select count(distinct f.nro_factura) from rocket_Database.facturas f where f.id_empresa = id_empresa " +
            "and f.fecha_alta > convert(datetime, '" + FECHA_INICIO + "') and f.fecha_alta < convert(datetime, '" + FECHA_FIN + "')) " +
            ") as porcentaje_pagado from rocket_database.empresas order by porcentaje_pagado desc ";

        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public PorcentajeFacturasPagadasDao()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("porcentaje");
        }

        public List<T> obtenerPorcentajesPagados(int anio, int trimestre)
        {
            String fechaInicio = Utils.Utils.getInicioTrimestre(anio, trimestre);
            String fechaFin = Utils.Utils.getFinTrimestre(anio, trimestre);
            String query = PORCENTAJE_PAGADO;
            query = query.Replace(FECHA_INICIO, fechaInicio);
            query = query.Replace(FECHA_FIN, fechaFin);
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }
    }

    class EmpresasConMontoRendidoDao<T> : Dao<T>
    {
        private const String FECHA_INICIO = "#FECHA_INICIO#";
        private const String FECHA_FIN = "#FECHA_FIN#";
        private const String PORCENTAJE_PAGADO =
            "select top 5 e.id_empresa, e.nombre, sum(r.valor_total) as rendicion_total from "+
            "rocket_Database.EMPRESAS e, rocket_database.RENDICIONES r "+
            "where r.id_empresa = e.id_empresa " +
            "and r.fecha > convert(datetime, '"+ FECHA_INICIO +"') and r.fecha < convert(datetime, '"+ FECHA_FIN +"') "+
            "group by e.id_empresa, e.nombre "+
            "order by rendicion_total desc ";

        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public EmpresasConMontoRendidoDao()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);

            allColumns.Add("id");
            allColumns.Add("nombre");
            allColumns.Add("montoRendido");
        }

        public List<T> obtenerMayoresMontosRendidos(int anio, int trimestre)
        {
            String fechaInicio = Utils.Utils.getInicioTrimestre(anio, trimestre);
            String fechaFin = Utils.Utils.getFinTrimestre(anio, trimestre);
            String query = PORCENTAJE_PAGADO;
            query = query.Replace(FECHA_INICIO, fechaInicio);
            query = query.Replace(FECHA_FIN, fechaFin);
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }
    }
}
