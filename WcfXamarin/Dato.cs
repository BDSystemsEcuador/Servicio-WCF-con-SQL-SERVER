// utilizar las librerias necesarias:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Librerias para la conexión a la base de datos
using System.Data.SqlClient;
using System.Data;
//Sirve para poder utilizar la clase desde otro proyecto - nombre de la solución
namespace WcfXamarin
{
    //Clase dato
    public class Dato
    {
        //Cadena de conexion
        //static - No permite las propiedades de POO
        //Data source: la dirección de la base de datos puede ser: ".", "localhost","192.292.---" 
        //Integrated security = true: Es true si la base de datos es local y false si necesitamos especificar el user y el pass
        //Initial Catalog: Nombre de la bd
        private static string cadena = "Data Source=.;Integrated Security=true;Initial Catalog=XamarinIT";
        
        //Es el método que va retornar una lista de Clientes y nombre es getClientSQL
        public static IList<Cliente> getClienteSQL()
        {
            //Es una clase de la libreria System.Data, y se instancia el objeto tabla
            DataTable tabla = new DataTable();
            //Es una clase de la libreria System.Data, y se instancia el objeto ada y recibe como parámetros la sentencia SQL Select(seleccina todo desde cliente),y cadena
            SqlDataAdapter ada = new SqlDataAdapter("Select * from cliente", cadena);
            //llenamos el objeto ada con el objeto tabla
            ada.Fill(tabla);
            //Es una lista de tipo Cliente llamada retorno y está vacia
            IList<Cliente> retorno = new List<Cliente>();
            //Es un bucle que recorre las filas de mi tabla
            // 0   1 2 3 4
            // 1e  2e
            // tabla.Rows.Coun -> registros que estan en la tabla
            for(int i = 0; i < tabla.Rows.Count; i++)
            {
                //Instanciando un objeto llamado item y estamos ingresando los datos al constructor, 
                Cliente item = new Cliente()
                {
                    //ruc,name, y codigo es igual al valor que me trae de la tabla de elementos i 
                    ruc = tabla.Rows[i]["ruc"] + "",
                    name = tabla.Rows[i]["name"] + "",
                    codigo = tabla.Rows[i]["codigo"] + "",
                };
                //llenamos la lista retorno con objetos de tipo cliente
                retorno.Add(item);
            }
            //retornamos la lista me va a dar como resultado {[ruc: 213123,name: daniel, codigo: 123123],[ruc 23423,name camila, codigo 345]}
            return retorno;
        }
        public static IList<Factura> getFacturaSQL()
        {
            //Es una clase de la libreria System.Data, y se instancia el objeto tabla
            DataTable tabla = new DataTable();
            //Es una clase de la libreria System.Data, y se instancia el objeto ada y recibe como parámetros la sentencia SQL Select(seleccina todo desde cliente),y cadena
            SqlDataAdapter ada = new SqlDataAdapter("Select * from factura", cadena);
            //llenamos el objeto ada con el objeto tabla
            ada.Fill(tabla);
            //Es una lista de tipo Cliente llamada retorno y está vacia
            IList<Factura> retorno = new List<Factura>();
            //Es un bucle que recorre las filas de mi tabla
            // 0   1 2 3 4
            // 1e  2e
            // tabla.Rows.Coun -> registros que estan en la tabla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                //Instanciando un objeto llamado item y estamos ingresando los datos al constructor, 
                Factura item = new Factura()
                {
                    //ruc,name, y codigo es igual al valor que me trae de la tabla de elementos i 
                    id = tabla.Rows[i]["id"] + "",
                    nameEmpresa = tabla.Rows[i]["nameEmpresa"] + "",
                    fecha = tabla.Rows[i]["fecha"] + "",
                    name = tabla.Rows[i]["name"] + "",
                };
                //llenamos la lista retorno con objetos de tipo cliente
                retorno.Add(item);
            }
            //retornamos la lista me va a dar como resultado {[ruc: 213123,name: daniel, codigo: 123123],[ruc 23423,name camila, codigo 345]}
            return retorno;
        }

        public static IList<Venta> getVentaSQL()
        {
            //Es una clase de la libreria System.Data, y se instancia el objeto tabla
            DataTable tabla = new DataTable();
            //Es una clase de la libreria System.Data, y se instancia el objeto ada y recibe como parámetros la sentencia SQL Select(seleccina todo desde cliente),y cadena
            SqlDataAdapter ada = new SqlDataAdapter("select factura.nameEmpresa, venta.cantidad from factura inner join venta on factura.id = venta.fk_factura;", cadena);
            //llenamos el objeto ada con el objeto tabla
            ada.Fill(tabla);
            //Es una lista de tipo Cliente llamada retorno y está vacia
            IList<Venta> retorno = new List<Venta>();
            //Es un bucle que recorre las filas de mi tabla
            // 0   1 2 3 4
            // 1e  2e
            // tabla.Rows.Coun -> registros que estan en la tabla
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                //Instanciando un objeto llamado item y estamos ingresando los datos al constructor, 
                Venta item = new Venta()
                {
                    //ruc,name, y codigo es igual al valor que me trae de la tabla de elementos i 
                    
                    cantidad = Convert.ToInt32(tabla.Rows[i]["cantidad"]),
                    nameEmpresa = tabla.Rows[i]["nameEmpresa"] + "",
                };
                //llenamos la lista retorno con objetos de tipo cliente
                retorno.Add(item);
            }
            //retornamos la lista me va a dar como resultado {[ruc: 213123,name: daniel, codigo: 123123],[ruc 23423,name camila, codigo 345]}
            return retorno;
        }
    }
}
