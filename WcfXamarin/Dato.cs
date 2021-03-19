using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace WcfXamarin
{
    public class Dato
    {
        private static string cadena = "Data Source=.;Integrated Security=true;Initial Catalog=XamarinIT";
        public static IList<Cliente> getClienteSQL()
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter("Select * from cliente", cadena);
            ada.Fill(tabla);
            IList<Cliente> retorno = new List<Cliente>();
            for(int i = 0; i < tabla.Rows.Count; i++)
            {
                Cliente item = new Cliente()
                {
                    ruc = tabla.Rows[i]["ruc"] + "",
                    name = tabla.Rows[i]["name"] + "",
                    codigo = tabla.Rows[i]["codigo"] + "",
                };
                retorno.Add(item);
            }
            return retorno;
        }
    }
}