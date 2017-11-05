using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    public class Empresa
    {

        public int id;
        public String cuit;
        public String nombre;
        public String direccion;
        public int idRubro;
        public Boolean activo;
        public DateTime fechaRendicion;
    }

}
