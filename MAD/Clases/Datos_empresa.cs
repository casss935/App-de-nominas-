
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cassandra;
namespace MAD.Clases
{
    public class Datos_empresa
    {
        public Guid ID_empresa { get; set; }
        public string razon_social { get; set; }
        public string rfc { get; set; }
        public string regis_patronal { get; set; }
        public DateTime fechainicio { get; set; }
        public string address { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string codigopostal { get; set; }        
    }
}