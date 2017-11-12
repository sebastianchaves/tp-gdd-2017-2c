using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    public class Rendicion
    {
        public int id;
        public int cantidadFacturas;
        public DateTime fecha;
        public decimal comision;
        public decimal valorTotal;
        public int porcentaje;
        public int idEmpresa;

        public String nombreEmpresa;
    }
}
