using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.contenedores_puesto;

namespace MAD.contenedoresHome
{
    public partial class HOME_addpuesto : UserControl
    {
        public HOME_addpuesto()
        {
            InitializeComponent();
            PST_CONT_crear crear = new PST_CONT_crear();
            AddContenedores_PST(crear);

        }
        private void AddContenedores_PST(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PST_PANEL_home.Controls.Clear();
            PST_PANEL_home.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void PST_BTN_crear_Click(object sender, EventArgs e)
        {
            PST_CONT_crear crear = new PST_CONT_crear();
            AddContenedores_PST(crear);

        }

        private void PST_BTN_up_del_Click(object sender, EventArgs e)
        {
            PST_CONT_updel updel = new PST_CONT_updel();
            AddContenedores_PST(updel);
        }

        private void PST_BTN_del_Click(object sender, EventArgs e)
        {
            PST_CONT_del _Del = new PST_CONT_del();
            AddContenedores_PST(_Del);
        }
    }
}
