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
using MAD.contenedores_departamento;

namespace MAD.contenedoresHome
{
    public partial class HOME_adddepartamento : UserControl
    {
        public HOME_adddepartamento()
        {
            InitializeComponent();
            CONT_DEP_crear dep = new CONT_DEP_crear();
            AddContenedores_dep(dep);
        }
        private void AddContenedores_dep(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            DEP_PANEL_home.Controls.Clear();
            DEP_PANEL_home.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DEP_BTN_crear_Click(object sender, EventArgs e)
        {
            CONT_DEP_crear dep = new CONT_DEP_crear();
            AddContenedores_dep(dep);
        }

        private void DEP_BTN_update_Click_1(object sender, EventArgs e)
        {
            CONT_DEP_up_del updel = new CONT_DEP_up_del();
            AddContenedores_dep(updel);
        }

        private void DEP_BTN_delete_Click(object sender, EventArgs e)
        {
            CONT_DEP_delete delete = new CONT_DEP_delete();
            AddContenedores_dep(delete);
        }
    }
}
