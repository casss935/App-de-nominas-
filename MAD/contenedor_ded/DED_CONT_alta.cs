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

namespace MAD.contenedor_ded
{
    public partial class DED_CONT_alta : UserControl
    {
        public DED_CONT_alta()
        {
            InitializeComponent();
        }

        private void DED_BTN_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DED_TB_nombre.Text) && String.IsNullOrEmpty(DED_TB_cantidad.Text) && (DED_CCKB_no.Checked || DED_CCKB_si.Checked))
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Datos_deduccion deduccion = new Datos_deduccion();
                Guid guid = Guid.NewGuid();
                deduccion.ID_deduc = guid;
                deduccion.ID_empresa = statics.ID_empresa;
                deduccion.name = DED_TB_nombre.Text;
                deduccion.monto = float.Parse(DED_TB_cantidad.Text);
                deduccion.tipo = DED_CB_tipo.Text;
                if (DED_CCKB_si.Checked)
                {
                    deduccion.fija = "FIJO";
                }
                if (DED_CCKB_no.Checked)
                {
                    deduccion.fija = "NOFIJO";
                }
                EnlaceCassandra enlace = new EnlaceCassandra();
                bool sionel = enlace.agregar_deduccion(deduccion);
                if (sionel)
                {
                    MessageBox.Show("Deduccion dada de alta correctamente", "Deduccion", MessageBoxButtons.OK);
                    DED_TB_nombre.ResetText();
                    DED_TB_cantidad.ResetText();
                    DED_CB_tipo.ResetText();
                    DED_CCKB_si.ResetText();
                    DED_CCKB_no.ResetText();
                }
                

            }
        }
    }
}
