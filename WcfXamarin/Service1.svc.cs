using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfXamarin
{
    
    public class Service1 : IService1
    {
        public Cliente getCliente()
        {
            return new Cliente()
            {
                codigo = "001",
                name = "daniel",
                ruc = "32491235",
            };
        }

        public IList<Cliente> getClientes()
        {
            IList<Cliente> retorno = new List<Cliente>();
            for (int i = 0; i < 100; i++)
            {
                retorno.Add(new Cliente()
                {
                    codigo = "00" + i,
                    name = "cliente nmro" + i,
                    ruc = "32432" + i,
                });
            }
            return retorno;
        }

        public IList<Cliente> getClientesSQL()
        {
            return Dato.getClienteSQL();
        }

        public string GetData()
        {
            return "mi primer servicio";
        }
    }
}
