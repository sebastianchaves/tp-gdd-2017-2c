using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Rendicion
    {
        public int id;
        public int cantidadFacturas;
        public DateTime fecha;
        public decimal comision;
        public decimal valorTotal;
        public decimal porcentaje;
        public int idEmpresa;
    }
}
