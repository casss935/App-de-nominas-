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
using MAD.Clases;

namespace MAD.contenedores_colaborador
{
    public partial class Update_Colaborador : UserControl
    {
        public string rfc = "";
        public Update_Colaborador()
        {
            InitializeComponent();
            UP_PANEL_col.Hide();
        }



        private void UP_BTN_buscar_Click(object sender, EventArgs e)
        {
            
            rfc = UP_LABEL_rfc.Text;
            EnlaceCassandra enlace = new EnlaceCassandra();
            var lista = enlace.GetOneColaborador(rfc);
            foreach(var item in lista)
            {
                
                COL_TB_nombre.Text = item.GetValue<string>("name");              
                COL_TB_password.Text = item.GetValue<string>("password");
                COL_TB_departamento.Text = item.GetValue<string>("departamento");
                COL_TB_puesto.Text = item.GetValue<string>("puesto");
                COL_TB_bday.Text = item.GetValue<string>("bday");
                COL_TB_curp.Text = item.GetValue<string>("curp");
                COL_TB_nss.Text = item.GetValue<string>("nss");
                COL_TB_rfc.Text = item.GetValue<string>("rfc");

                
                COL_TB_banco.Text = item.GetValue<string>("banco");
                COL_TB_nocuenta.Text = item.GetValue<string>("no_cuenta");
                COL_TB_email.Text = item.GetValue<string>("email");
                COL_TB_phone.Text = item.GetValue<string>("telefono");

                COL_TB_address.Text = item.GetValue<string>("address"); 
                COL_TB_municipio.Text = item.GetValue<string>("municipio"); 
                COL_TB_estado.Text = item.GetValue<string>("estado"); 
                COL_TB_cp.Text = item.GetValue<string>("codigopostal"); ;
            }

        }

        private void COL_BTN_update_Click(object sender, EventArgs e)
        {
            datos_colaborador datos = new datos_colaborador();
            datos.name = COL_TB_nombre.Text;
            datos.password = COL_TB_password.Text;
            datos.departamento = COL_TB_departamento.Text;
            datos.puesto = COL_TB_puesto.Text;
            datos.bday = COL_TB_bday.Value;
            datos.curp = COL_TB_curp.Text;
            datos.nss = COL_TB_nss.Text;
            datos.rfc = COL_TB_rfc.Text;
            datos.banco = COL_TB_banco.Text;
            datos.no_cuenta = COL_TB_nocuenta.Text;
            datos.email = COL_TB_email.Text;
            datos.telefono = COL_TB_phone.Text;
            datos.address = COL_TB_address.Text;
            datos.municipio = COL_TB_municipio.Text;
            datos.estado = COL_TB_estado.Text;
            datos.codigopostal = COL_TB_cp.Text;

        }
    }
}
