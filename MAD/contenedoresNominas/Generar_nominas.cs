using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Nominas;

namespace MAD.contenedoresNominas
{
    public partial class WN_Generar_nominas : UserControl
    {
        public WN_Generar_nominas()
        {
            InitializeComponent();
            CONT_GNR_nomina nomina = new CONT_GNR_nomina();
            AddContenedores_Nominas(nomina);

        }
        private void AddContenedores_Nominas(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            NMN_PANEL_home.Controls.Clear();
            NMN_PANEL_home.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void NMN_BTN_comprobar_Click(object sender, EventArgs e)
        {
            CONT_VRFC_nomina verficar = new CONT_VRFC_nomina();
            AddContenedores_Nominas(verficar);
        }

        private void NMN_BTN_gnomina_Click(object sender, EventArgs e)
        {
            CONT_GNR_nomina nomina = new CONT_GNR_nomina();
            AddContenedores_Nominas(nomina);
        }

        private void NMN_BTN_delete_Click(object sender, EventArgs e)
        {
            CONT_DLT_nomina delete = new CONT_DLT_nomina();
            AddContenedores_Nominas(delete);

        }
    }
}
