using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class EmpresaDAO<T>: Dao<T>
    {

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

            allColumnsInDB.Add("id");
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

            insert(EMPRESAS, allColumnsInDB, tipos, valores);
        }

        // Selects
        public List<T> findEmpresas()
        {
            Condicion condicion = new Condicion();

            List<List<String>> resultSet = this.select(EMPRESAS, ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
        }

        public List<T> findEmpresa(String nombreEmpresa, String cuitEmpresa, String rubroEmpresa)
        {
            Condicion condicion = new Condicion();
            condicion.agregarCondicion("e.nombre", nombreEmpresa, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("e.cuit", cuitEmpresa, Utils.Utils.STRING_TYPE);
            condicion.agregarCondicion("r.nombre", rubroEmpresa, Utils.Utils.STRING_TYPE);

            List<List<String>> resultSet = this.select(EMPRESAS + " e, " + RUBROS + " r", ALL, tipos, condicion);
            return getEntities(resultSet, allColumns, tipos);
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

            Condicion condicion = new Condicion();

            condicion.agregarCondicion("id_empresa", empresaUpdate.id, Utils.Utils.INT_TYPE);

            update(EMPRESAS, actualizacion, condicion);
        }

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
        public List<T> obtenerEmpresasPorDiaDeRendicion(int dia)
        {
            return obtenerPorQueryGenerica(EMPRESAS_POR_DIA_DE_RENDICION + dia.ToString(), allColumns, tipos);
        }
    }
}
