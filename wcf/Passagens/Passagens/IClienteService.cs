using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract, WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddCliente/{nome};{cpf}")]
        bool Add(string nome, string cpf);

        [OperationContract, WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "SearchClientes/{nome}")]
        Cliente Search(string nome);

        [OperationContract, WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetClientes/")]
        IList<Cliente> GetCLientes();
    }
}
