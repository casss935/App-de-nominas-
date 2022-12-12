using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace MAD.Clases
{
    public class datos_colaborador
    {
		public Guid ID_numero { get; set; }
		public Guid ID_empresa {get; set;}
		public string name {get; set;}
		public string password {get; set;}
		public string departamento {get; set;}
		public Guid id_dep { get; set; }
		public string puesto {get; set;}
		public Guid id_puesto { get; set; }
		public DateTime registro {get; set;}
		public DateTime bday { get; set; }
		public LocalDate bdayld { get; set; }
		public string curp {get; set;}
		public string nss {get; set;}
		public string rfc {get; set;}
		public string banco {get; set;}
		public string no_cuenta {get; set;}
		public string email {get; set;}
		public string telefono {get; set;}
		public string address {get; set;}
		public string estado {get; set;}
		public string municipio {get; set;}
		public string codigopostal {get; set;}
    }
}
