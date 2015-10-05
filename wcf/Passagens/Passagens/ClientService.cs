using System;
using System.Collections.Generic;

namespace Passagens
{
    public class ClientService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            var result = false;

            try
            {
                var dao = new ClienteDAO();
                var cliente = new Cliente();
                cliente.CPF = cpf;
                cliente.Nome = nome;
                dao.Add(cliente);
                result = true;
            }
            catch
            {

            }

            return result;
        }

        public IList<Cliente> GetCLientes()
        {
            return ClienteDAO.clientes;
        }

        public Cliente Search(string nome)
        {
            var dao = new ClienteDAO();
            return dao.Search(nome);
        }
    }
}
