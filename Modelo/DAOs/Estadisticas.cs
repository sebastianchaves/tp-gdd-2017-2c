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
        private const String EMPRESA_CON_MONTOS =
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
            String query = EMPRESA_CON_MONTOS;
            query = query.Replace(FECHA_INICIO, fechaInicio);
            query = query.Replace(FECHA_FIN, fechaFin);
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }
    }

    class ClienteConPagosDAO<T> : Dao<T>
    {
        private const String FECHA_INICIO = "#FECHA_INICIO#";
        private const String FECHA_FIN = "#FECHA_FIN#";
        private const String CLIENTE_CON_PAGOS =
            "select TOP 5 c.id_cliente, c.apellido, c.nombre, count(1) as pagos " +
            "from rocket_database.clientes c, rocket_Database.pagos p " +
            "where p.id_cliente = c.id_cliente " +
            "and p.fecha_cobro > convert(datetime, '" + FECHA_INICIO + "') " +
            "and p.fecha_cobro < convert(datetime, '" + FECHA_FIN + "') " +
            "group by c.id_cliente, c.apellido, c.nombre order by pagos desc";

        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public ClienteConPagosDAO()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.INT_TYPE);

            allColumns.Add("idCliente"); 
            allColumns.Add("apellido");  
            allColumns.Add("nombre");
            allColumns.Add("pagos"); 
        }

        public List<T> obtenerClientesConMasPagos(int anio, int trimestre)
        {
            String fechaInicio = Utils.Utils.getInicioTrimestre(anio, trimestre);
            String fechaFin = Utils.Utils.getFinTrimestre(anio, trimestre);
            String query = CLIENTE_CON_PAGOS;
            query = query.Replace(FECHA_INICIO, fechaInicio);
            query = query.Replace(FECHA_FIN, fechaFin);
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }
    }

    class PorcentajeFacturasPagadas<T> : Dao<T>
    {
        private const String FECHA_INICIO = "#FECHA_INICIO#";
        private const String FECHA_FIN = "#FECHA_FIN#";
        private const String PORCENTAJE_FACTURAS_PAGADAS =
"select c.id_cliente, c.apellido, c.nombre, ( convert(decimal(5, 2), " +
"(select count(1) from ROCKET_DATABASE.facturas f, rocket_database.pago_factura p " +
"where f.id_cliente = c.id_cliente and f.id_factura = p.id_factura and " +
"f.fecha_alta > convert(datetime, '#FECHA_INICIO#') and f.fecha_alta < convert(datetime, '#FECHA_FIN#')) * 100.0 / " +
"(select count(1) from ROCKET_DATABASE.facturas f where f.id_cliente = c.id_cliente AND " +
"f.fecha_alta > convert(datetime, '#FECHA_INICIO#') and f.fecha_alta < convert(datetime, '#FECHA_FIN#')))) as porcentajePagados " +
"from ROCKET_DATABASE.clientes c ";

        private List<String> tipos;
        private List<String> allColumns;
        private List<String> allColumnsInDB;

        public PorcentajeFacturasPagadas()
        {
            this.tipos = new List<String>();
            this.allColumns = new List<String>();
            this.allColumnsInDB = new List<String>();

            tipos.Add(Utils.Utils.INT_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.STRING_TYPE);
            tipos.Add(Utils.Utils.DECIMAL_TYPE);

            allColumns.Add("idCliente");
            allColumns.Add("apellido");
            allColumns.Add("nombre");
            allColumns.Add("porcentajePagados");
        }

        public List<T> obtenerPorcentajeFacturasPagadas(int anio, int trimestre)
        {
            String fechaInicio = Utils.Utils.getInicioTrimestre(anio, trimestre);
            String fechaFin = Utils.Utils.getFinTrimestre(anio, trimestre);
            String query = PORCENTAJE_FACTURAS_PAGADAS;
            query = query.Replace(FECHA_INICIO, fechaInicio);
            query = query.Replace(FECHA_FIN, fechaFin);
            return obtenerPorQueryGenerica(query, allColumns, tipos);
        }
    }
}
