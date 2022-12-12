using MAD.contenedoresNominas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD.contenedores
{
    public partial class ID_nominas : UserControl
    {
        public ID_nominas()
        {
            InitializeComponent();
            WN_Generar_nominas WN = new WN_Generar_nominas();
            AddContenedoresNom(WN);

        }
        private void AddContenedoresNom(UserControl userControlNom)
        {
            ID_panel_home_nominas.Dock = DockStyle.Fill;
            ID_panel_home_nominas.Controls.Clear();
            ID_panel_home_nominas.Controls.Add(userControlNom);
            userControlNom.BringToFront();

        }
        private void Nom_button_Generar_Nominas_Click(object sender, EventArgs e)
        {
            WN_Generar_nominas WN = new WN_Generar_nominas();
            AddContenedoresNom(WN);
        }

        private void Nom_button_percepciones_Click(object sender, EventArgs e)
        {
            WN_percepciones WN = new WN_percepciones();
            AddContenedoresNom(WN);
        }

        private void Nom_button_deducciones_Click(object sender, EventArgs e)
        {
            WN_deducciones WN = new WN_deducciones();
            AddContenedoresNom(WN);
        }
    }
}
