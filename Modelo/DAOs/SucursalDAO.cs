using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{
    class SucursalDAO
    {

        // Adds
        public void agregarSucursal(Sucursal nuevaSucursal)
        {

        }

        // Updates
        public void updateSucursal(Sucursal sucursalModificada)
        {

        }

        // Exists
        public Boolean existeCodigoPostal(int codigoPostal)
        {
            return false;
        }

        // Finds
        public IList<Sucursal> findSucursal(String nombreSucursal, 
                                            String direccionSucursal, 
                                            int codigoPostalSucursal)
        {
            IList<Sucursal> resultados = new List<Sucursal>();

            // TODO para probar
            resultados.Add(new Sucursal("NOMBRE_PRUEBA_1", "DIRECCION_PRUEBA_1", 1, true));
            resultados.Add(new Sucursal("NOMBRE_PRUEBA_2", "DIRECCION_PRUEBA_2", 2, false));
            resultados.Add(new Sucursal("NOMBRE_PRUEBA_3", "DIRECCION_PRUEBA_3", 3, true));
            resultados.Add(new Sucursal("NOMBRE_PRUEBA_4", "DIRECCION_PRUEBA_4", 4, false));

            return resultados;
        }

    }
}
