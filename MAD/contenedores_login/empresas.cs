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
using Cassandra;
using Cassandra.Data;

namespace MAD.contenedores_login
{
    public partial class WD_ID_empresas : UserControl
    {
        public WD_ID_empresas()
        {
            InitializeComponent();
            EMP_PANEL_title.Hide();
            EMP_LABEL_empresa.Hide();
        }

        private void WD_ID_empresas_Load(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var lista = enlace.Get_empresa();
            TABLA_empresas.DataSource = lista;
            TABLA_empresas.Columns["razon_social"].HeaderText = "EMPRESA";
            TABLA_empresas.Columns["rfc"].HeaderText = "RFC";
            TABLA_empresas.Columns["regis_patronal"].Visible = false;
            TABLA_empresas.Columns["FechaInicio"].HeaderText = "FECHA";
            TABLA_empresas.Columns["address"].Visible = false;
            TABLA_empresas.Columns["estado"].Visible = false;
            TABLA_empresas.Columns["municipio"].Visible = false;
            TABLA_empresas.Columns["codigopostal"].Visible = false;
            TABLA_empresas.Columns["ID_empresa"].HeaderText = "ID";
            TABLA_empresas.Columns["int_FP"].Visible = false;            
        }

        private void CTD_EMP_BTN_aceptar_Click(object sender, EventArgs e)
        {
            WD_ID_login _Login = new WD_ID_login();
            Window_login window_Login = new Window_login();
            window_Login.AddContenedores_login(_Login);
        }

        private void TABLA_empresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = TABLA_empresas.Rows[e.RowIndex];
                TABLA_empresas.CurrentRow.Selected = true;
                statics.rfc_empresa = TABLA_empresas.Rows[e.RowIndex].Cells["RFC"].FormattedValue.ToString();
                statics.ID_empresa = Guid.Parse(TABLA_empresas.Rows[e.RowIndex].Cells["ID_empresa"].FormattedValue.ToString());
                EnlaceCassandra enlace = new EnlaceCassandra();
                var lista = enlace.GetAllEmpresas();               
                
                foreach(var item in lista)
                {
                    if( statics.rfc_empresa == item.GetValue<string>("rfc"))
                    {
                        statics.nom_empresa = item.GetValue<string>("razon_social");
                        
                        break;
                    }
                }
                statics.login_panel = true;                
                TABLA_empresas.Hide();
                EMP_LABEL_title.Hide();
                EMP_PANEL_title.Show();
                EMP_LABEL_empresa.Show();
                EMP_LABEL_empresa.Text = statics.nom_empresa;              
            }
        }

        private void Login_BTN_login_Click(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var listausersadmins = enlace.GetAllUserAdmins();
            bool nohaypan = false;

            foreach (var item in listausersadmins)
            {

                if (Login_TB_user.Text == item.GetValue<string>("user"))
                {

                    if (Login_TB_password.Text == item.GetValue<string>("password"))
                    {
                        Login_TB_user.ResetText();
                        Login_TB_password.ResetText();
                        statics.nom_useradmin = item.GetValue<string>("user");
                        nohaypan = true;
                        Form1 form1 = new Form1();
                        form1.Show();
                        break;
                    }
                }
            }

            if (nohaypan)
            {
                MessageBox.Show("Verifique bien la contraseña y el usuario", "Iniciar sesion", MessageBoxButtons.OK);
            }
        }
    }
}
