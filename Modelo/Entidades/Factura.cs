using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Factura
    {
        // Atributos
        public int idCliente;
        public int idEmpresa;
        public int numero;
        public DateTime fechaAlta;
        public DateTime fechaVencimiento;
        public List<ItemFactura> items;

        // Constructores
        public Factura()
        {

        }
    }
}
