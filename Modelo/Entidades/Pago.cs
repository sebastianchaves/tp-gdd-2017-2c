﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    public class Pago
    {
        public int id;
        public DateTime fechaCobro;
        public decimal importe;
        public int idFormaPago;
        public int idSucursal;
        public int idCliente;
    }

}
