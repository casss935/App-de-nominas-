using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.contenedor_ded;

namespace MAD.contenedoresNominas
{
    public partial class WN_deducciones : UserControl
    {
        public WN_deducciones()
        {
            InitializeComponent();
            DED_CONT_alta alta = new DED_CONT_alta();
            AddContenedores_ded(alta);
        }
        private void AddContenedores_ded(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DED_PANEL_home.Controls.Clear();
            DED_PANEL_home.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DED_BTN_alta_Click(object sender, EventArgs e)
        {
            DED_CONT_alta alta = new DED_CONT_alta();
            AddContenedores_ded(alta);

        }

        private void DED_BTN_update_Click(object sender, EventArgs e)
        {
            DED_CONT_update update = new DED_CONT_update();
            AddContenedores_ded(update);

        }

        private void DED_BTN_delete_Click(object sender, EventArgs e)
        {
            DED_CONT_delete delete = new DED_CONT_delete();

        }
    }
}
