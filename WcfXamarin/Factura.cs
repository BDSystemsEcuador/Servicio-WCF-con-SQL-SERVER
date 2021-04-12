using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfXamarin
{
    public class Facturas
    {
        public Factura[] factura;
    }
    public class Factura
    {
        public string id;
        public string nameEmpresa;
        public string fecha;
        public string name;
    }
}