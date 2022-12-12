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

namespace MAD.contenedor_deducciones
{
    public partial class PERS_CONT_alta : UserControl
    {
        public PERS_CONT_alta()
        {
            InitializeComponent();
        }

        private void PERS_BTN_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PERS_TB_nombre.Text) && String.IsNullOrEmpty(PERS_TB_cantidad.Text) && String.IsNullOrEmpty(PERS_CB_tipo.Text) && (PERS_CCKB_si.Checked || PERS_CCKB_no.Checked))
            {

            }
            else
            {
                Datos_pers pers = new Datos_pers();
                pers.ID_empresa = statics.ID_empresa;
                Guid guid = Guid.NewGuid();
                pers.ID_percep = guid;
                pers.name = PERS_TB_nombre.Text;
                pers.monto = float.Parse(PERS_TB_cantidad.Text);
                pers.tipo = PERS_CB_tipo.Text;
                if (PERS_CCKB_si.Checked)
                {
                    pers.fija = "FIJO";
                }
                if (PERS_CCKB_no.Checked)
                {
                    pers.fija = "NOFIJO";
                }
                EnlaceCassandra enlace = new EnlaceCassandra();
                bool sionel = enlace.agregar_pers(pers);
                if (sionel)
                {
                    MessageBox.Show("La percepcion se dio de alta correctamente", "Percepcion", MessageBoxButtons.OK);
                    PERS_CB_tipo.ResetText();
                    PERS_CCKB_no.ResetText();
                    PERS_CCKB_si.ResetText();
                    PERS_TB_cantidad.ResetText();
                    PERS_TB_nombre.ResetText();
                }

            }
        }
    }
}
