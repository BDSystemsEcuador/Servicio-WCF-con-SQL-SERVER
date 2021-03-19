using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfXamarin
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract,WebGet(UriTemplate="GetData",ResponseFormat =WebMessageFormat.Json)]
        string GetData();
        [OperationContract, WebGet(UriTemplate = "getCliente", ResponseFormat = WebMessageFormat.Json)]
        Cliente getCliente();
        [OperationContract, WebGet(UriTemplate = "getClientes", ResponseFormat = WebMessageFormat.Json)]
        IList<Cliente> getClientes();
        [OperationContract, WebGet(UriTemplate = "getClientesSQL", ResponseFormat = WebMessageFormat.Json)]
        IList<Cliente> getClientesSQL();
    }
}
