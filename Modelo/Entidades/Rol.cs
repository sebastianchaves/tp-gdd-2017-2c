using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Rol
    {

        public int id;
        public String nombre;
        public String descripcion;
        public Boolean habilitado;

        public List<Funcionalidad> funcionalidades;
        public int indexCombo;

        public Rol()
        {
            this.funcionalidades = new List<Funcionalidad>();
        }

    }
}
