using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class EmpresaDAO
    {
        // Adds
        public void agregarEmpresa(Empresa empresa)
        {

        }

        // Updates
        public void updateEmpresa(Empresa empresaUpdate)
        {

        }

        // Exists
        public Boolean existeCuit(int cuit)
        {
            return false;
        }

        // Finds
        public List<String> findRubrosDisponibles()
        {
            List<String> rubros = new List<String>();
            
            // TODO es para probar
            rubros.Add("RUBRO_PRUEBA_1");
            rubros.Add("RUBRO_PRUEBA_2");
            rubros.Add("RUBRO_PRUEBA_3");
            rubros.Add("RUBRO_PRUEBA_4");

            return rubros;
        }

        public IList<Empresa> findEmpresa(String nombreEmpresa, int cuitEmpresa, String rubroEmpresa)
        {
            IList<Empresa> resultados = new List<Empresa>();

            // TODO para probar
            resultados.Add(new Empresa("NOMBRE_PRUEBA_1", cuitEmpresa, "RUBRO_PRUEBA_1", "DIRECCION_PRUEBA_1", true));
            resultados.Add(new Empresa("NOMBRE_PRUEBA_2", cuitEmpresa, "RUBRO_PRUEBA_2", "DIRECCION_PRUEBA_2", false));
            resultados.Add(new Empresa("NOMBRE_PRUEBA_3", cuitEmpresa, "RUBRO_PRUEBA_3", "DIRECCION_PRUEBA_3", true));
            resultados.Add(new Empresa("NOMBRE_PRUEBA_4", cuitEmpresa, "RUBRO_PRUEBA_4", "DIRECCION_PRUEBA_4", false));

            return resultados;
        }

    }
}
