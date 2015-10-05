using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    class ClienteDAO
    {
        public static IList<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente Search(string nome)
        {
            return clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}
