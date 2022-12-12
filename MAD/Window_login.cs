using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using WindowsFormsApplication2;
using MAD.contenedores_login;

namespace MAD
{
    public partial class Window_login : Form
    {
        public Window_login()
        {
            InitializeComponent();
            if (!statics.login_panel)
            {
                EnlaceCassandra enlace = new EnlaceCassandra();
                var lista = enlace.GetAllEmpresas();
                var siono = lista.Any();                
                if (siono)
                {
                    WD_ID_empresas wD_ID_Empresas = new WD_ID_empresas();
                    AddContenedores_login(wD_ID_Empresas);

                }
                else
                {
                    WD_ID_Error_empresa wD_ID_Error_Empresa = new WD_ID_Error_empresa();
                    AddContenedores_login(wD_ID_Error_Empresa);
                }
            }


        }
        public void AddContenedores_login(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            PANEL_CONTENEDORES_login.Controls.Clear();
            PANEL_CONTENEDORES_login.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
