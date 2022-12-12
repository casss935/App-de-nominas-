using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Clases
{
    public class Datos_puesto
    {
		public Guid ID_puesto { get; set; }		
		public Guid ID_empresa { get; set; }
		public string name { get; set; }
		public float nivel_salarial { get; set; }
	}
}
