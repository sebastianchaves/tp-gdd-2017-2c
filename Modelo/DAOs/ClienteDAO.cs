using PagoAgilFrba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    // TODO agregarCliente, existeDni, existeMail
    class ClienteDAO
    {

        // Adds
        public void agregarCliente(Cliente cliente)
        { 

        }

        // Exists
        public Boolean existeDni(int dni)
        {
            return false;
        }

        public Boolean existeMail(String mail)
        {
            return false;
        }

        // Finds
        public IList<Cliente> findCliente(string nombreCliente, string apellidoCliente, int dni)
        {
            IList<Cliente> resultados = new List<Cliente>();
            return resultados;
        }

        // Updates
        public void updateCliente(Cliente clienteUpdate)
        {

        }

    }
}
