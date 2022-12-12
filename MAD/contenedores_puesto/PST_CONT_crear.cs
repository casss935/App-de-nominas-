using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Clases;
using WindowsFormsApplication2;

namespace MAD.contenedores_puesto
{
    public partial class PST_CONT_crear : UserControl
    {
        public PST_CONT_crear()
        {
            InitializeComponent();
        }

        private void WADDE_BTN_re_Click(object sender, EventArgs e)
        {
            Datos_puesto datos_Puesto = new Datos_puesto();
            if (String.IsNullOrEmpty(PST_TB_name.Text) && String.IsNullOrEmpty(PST_TB_ns.Text))
            {
                MessageBox.Show("Lleno todo los campos", "Puesto", MessageBoxButtons.OK);
            }
            else {
                Guid guid = Guid.NewGuid();
                datos_Puesto.ID_empresa = statics.ID_empresa;
                datos_Puesto.ID_puesto = guid;
                datos_Puesto.name = PST_TB_name.Text;
                datos_Puesto.nivel_salarial = float.Parse(PST_TB_ns.Text);
                EnlaceCassandra enlace = new EnlaceCassandra();
                bool sionel = enlace.Agregar_puesto(datos_Puesto);
                if (sionel)
                {
                    MessageBox.Show("Se agrego correctamente", "Puesto", MessageBoxButtons.OK);
                    PST_TB_name.ResetText();
                    PST_TB_ns.ResetText();
                } 
            }

        }
    }
}
