using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Clases
{
    public class Datos_empresa2
    {
        public Guid ID_empresa { get; set; }
        public string razon_social { get; set; }
        public string rfc { get; set; }
        public string regis_patronal { get; set; }
        public LocalDate fechainicio { get; set; }
        public IEnumerable<int> int_FP { get; set; }
        public string address { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string codigopostal { get; set; }
    }
}
