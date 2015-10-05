using Passagens;
using System;
using System.ServiceModel;

namespace Hosting
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(ClientService));
            var endereco = new Uri("http://localhost:8080/clientes");
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                host.Open();
                ExibeInformacoesServico(host);
                Console.ReadLine();
                host.Close();

            }
            catch(Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach (var ed in sh.Description.Endpoints)
            {
                Console.WriteLine(ed.Address);
            }
        }
    }
}
