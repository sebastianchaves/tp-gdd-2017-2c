using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Sucursal
    {

        // Atributos
        public String nombre;
        public String direccion;
        public int codigoPostal;
        public Boolean habilitada;

        // Constructores
        public Sucursal()
        {
        }

        public Sucursal(String nombre, String direccion, int codigoPostal, Boolean habilitacion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.habilitada = habilitacion;
        }

    }
}
