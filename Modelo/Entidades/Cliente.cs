using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
   
    class Cliente
    {
        public String nombre;
        public String apellido;
        public int dni;
        public DateTime fechaDeNacimiento;
        public String telefono;
        public String mail;
        public String calle;
        public int numero;
        public String localidad;
        public int codigoPostal;
        public int piso;
        public String departamento;
        public Boolean habilitado;

        public Cliente()
        {
        }

    }

}
