using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    public class Factura
    {

        public int id;
        public int numero;
        public DateTime fechaAlta;
        public Decimal total;
        public DateTime fechaVencimiento;
        public int idCliente;
        public int idEmpresa;
        public int idRendicion;
        public bool pagada;

    }
}
