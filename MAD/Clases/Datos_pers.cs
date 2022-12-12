using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Clases
{
    public class Datos_pers
    {
        public Guid ID_percep { get; set; }
        public Guid ID_empresa { get; set; }
        public string name { get; set; }
        public float monto { get; set; }
        public string tipo { get; set; }
        public string fija { get; set; }

    }
}
