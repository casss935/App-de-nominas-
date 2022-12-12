using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace MAD.contenedores_login
{
    public partial class WD_ID_login : UserControl
    {
        public WD_ID_login()
        {
            InitializeComponent();
        }

        private void Login_BTN_login_Click(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var listausersadmins = enlace.GetAllUserAdmins();

            
            
            if (Login_CB_tipouser.Text == "Administrador")
            {
                foreach (var item in listausersadmins)
                {

                    if (Login_TB_user.Text == item.GetValue<string>("user"))
                    {

                        if (Login_TB_password.Text == item.GetValue<string>("password"))
                        {
                            Login_TB_user.ResetText();
                            Login_TB_password.ResetText();
                            Form1 form1 = new Form1();
                            form1.Show();

                            break;
                        }
                    }
                }

            }
            if(Login_CB_tipouser.Text == "Colaborador")
            {
                EnlaceCassandra enlaceCassandra = new EnlaceCassandra();

                var lista = enlaceCassandra.GetOneColaboradorByEmpresa();

                foreach (var item in lista)
                {
                    if(Login_TB_user.Text == item.rfc)
                    {
                        if (Login_TB_password.Text == item.password)
                        {
                            statics.name_colaborador = item.name;
                            statics.id_colaborador = item.ID_numero;
                            WindowColaborador windowColaborador = new WindowColaborador();
                            windowColaborador.Show();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de usuario", "Error", MessageBoxButtons.OK);
            }


        }

        private void WD_ID_login_Load(object sender, EventArgs e)
        {
            LOGIN_TB_empresa.Text = statics.nom_empresa;
        }
    }
}
