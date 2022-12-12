using MAD.Clases;
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
using Cassandra.Mapping;
using WindowsFormsApplication2;
using MAD.contenedores_login;


namespace MAD
{
    public partial class Add_empresa : Form
    {
        public Add_empresa()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void WADDE_BTN_re_Click(object sender, EventArgs e)
        {
            
            bool enviardatosempresa = false;
            bool enviardatosusuario = false;
            Datos_empresa datos_empresa = new Datos_empresa();
            useradmin useradmin = new useradmin();

            if (String.IsNullOrEmpty(WADDE_TB_rs.Text) && String.IsNullOrEmpty(WADDE_TB_rp.Text) && String.IsNullOrEmpty(WADDE_TB_rfc.Text) && String.IsNullOrEmpty(WADDE_TB_df.Text) && String.IsNullOrEmpty(WADDE_TB_estado.Text) && String.IsNullOrEmpty(WADDE_TB_municipio.Text) && String.IsNullOrEmpty(WADDE_TB_cp.Text)) {
                MessageBox.Show("Revise bien los datos de la empresa, todos los campos deben estar completos", "Datos de empresa", MessageBoxButtons.OK);
                enviardatosempresa = false;
            }
            else {
                
                datos_empresa.razon_social = WADDE_TB_rs.Text;
                datos_empresa.rfc = WADDE_TB_rfc.Text;
                datos_empresa.regis_patronal = WADDE_TB_rp.Text;
                datos_empresa.fechainicio = WADDE_DTP_date.Value;
                datos_empresa.address = WADDE_TB_df.Text;
                datos_empresa.estado = WADDE_TB_estado.Text;
                datos_empresa.municipio = WADDE_TB_municipio.Text;
                datos_empresa.codigopostal = WADDE_TB_cp.Text;
                enviardatosempresa = true;
            }

            if (String.IsNullOrEmpty(WADDE_TB_nameuser.Text)&& String.IsNullOrEmpty(WADDE_TB_user.Text)&& String.IsNullOrEmpty(WADDE_TB_password.Text)&& String.IsNullOrEmpty(WADDE_TB_cpassword.Text)&& (WADDE_TB_password.Text == WADDE_TB_cpassword.Text)   ){
                MessageBox.Show("Revise bien los datos del usuario, todos los campos deben estar completos", "Datos de usuario", MessageBoxButtons.OK);
                enviardatosusuario = false;
            }
            else{
                
                
                useradmin.name = WADDE_TB_nameuser.Text;
                useradmin.password = WADDE_TB_password.Text;
                useradmin.user = WADDE_TB_user.Text;
                enviardatosusuario = true;
            }
            if ( enviardatosempresa && enviardatosusuario){
                Guid ID = Guid.NewGuid();
                Guid other = Guid.NewGuid();
                datos_empresa.ID_empresa = ID;
                useradmin.ID_empresa = ID;
                useradmin.ID_useradmin = other;
                EnlaceCassandra enlace = new EnlaceCassandra();
                bool empresa = enlace.Agregar_empresa(datos_empresa, useradmin);
                if (empresa)
                {
                    statics.nom_empresa = datos_empresa.razon_social;
                    statics.rfc_empresa = datos_empresa.rfc;
                    statics.nom_useradmin = useradmin.name;
                    statics.ID_useradmin = useradmin.ID_useradmin;
                    WD_ID_login login = new WD_ID_login();
                    Window_login window_Login = new Window_login();
                    window_Login.AddContenedores_login(login);
                    this.Close();
                }                             
            }
        }
    }
}
