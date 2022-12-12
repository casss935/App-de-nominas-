using MAD.contenedoresHome;
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
    public partial class ID_inicio : UserControl
    {
        public ID_inicio()
        {
            InitializeComponent();
            HOME_home Home = new HOME_home();
            AddContenedoresHome(Home);

        }

        private void AddContenedoresHome(UserControl userControlHome)
        {
            userControlHome.Dock = DockStyle.Fill;
            HOME_panel_contenedores.Controls.Clear();
            HOME_panel_contenedores.Controls.Add(userControlHome);
            userControlHome.BringToFront();

        }

        private void HOME_BTN_home_Click(object sender, EventArgs e)
        {
            HOME_home Home = new HOME_home();
            AddContenedoresHome(Home);
        }

        private void HOME_BTN_adddepartamento_Click(object sender, EventArgs e)
        {
            HOME_adddepartamento Home = new HOME_adddepartamento();
            AddContenedoresHome(Home);
        }

        private void HOME_BTN_addpuesto_Click(object sender, EventArgs e)
        {
            HOME_addpuesto Home = new HOME_addpuesto();
            AddContenedoresHome(Home);
        }
    }
}
