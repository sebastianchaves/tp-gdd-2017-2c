using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Pago
    {
        public int id;
        public DateTime fechaCobro;
        public int importe;
        public int idFormaPago;
        public int idSucursal;
    }

}
