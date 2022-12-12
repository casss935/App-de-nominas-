using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD;
using MAD.Clases;
using WindowsFormsApplication2;

namespace MAD.contenedores_colaborador
{
    public partial class Alta_Colaboradores : UserControl
    {
        public Alta_Colaboradores()
        {
            InitializeComponent();
        }
        private void COL_BTN_alta_Click(object sender, EventArgs e)
        {
            datos_colaborador datos = new datos_colaborador();
            bool datosgenerales = false;
            bool otrosdatos = false;
            bool datosdireccion = false;

            if (String.IsNullOrEmpty(COL_TB_nombre.Text) && String.IsNullOrEmpty(COL_TB_password.Text) && String.IsNullOrEmpty(COL_CB_departamento.Text) && String.IsNullOrEmpty(COL_CB_puesto.Text) && String.IsNullOrEmpty(COL_TB_bday.Text) && String.IsNullOrEmpty(COL_TB_curp.Text) && String.IsNullOrEmpty(COL_TB_nss.Text) && String.IsNullOrEmpty(COL_TB_rfc.Text))
            {
                MessageBox.Show("Revise los datos generales", "Colaborador", MessageBoxButtons.OK);
                datosgenerales = false;
            }
            else
            {

                datos.name = COL_TB_nombre.Text;
                datos.ID_empresa = statics.ID_empresa;
                datos.password = COL_TB_password.Text;
                datos.departamento = COL_CB_departamento.Text;
                EnlaceCassandra enlace = new EnlaceCassandra();
                var listadep = enlace.Get_departamento();
                foreach (var item in listadep)
                {
                    if(datos.departamento == item.name)
                    {
                        datos.id_dep = item.ID_dep;
                    }
                }
                datos.puesto = COL_CB_puesto.Text;
                EnlaceCassandra cassandra = new EnlaceCassandra();
                var listapuesto = cassandra.Get_puesto();
                foreach(var item in listapuesto)
                {
                    if(datos.puesto == item.name)
                    {
                        datos.id_puesto = item.ID_puesto;
                    }
                }
                datos.bday = COL_TB_bday.Value;
                datos.curp = COL_TB_curp.Text;
                datos.nss = COL_TB_nss.Text;
                datos.rfc = COL_TB_rfc.Text;
                datosgenerales = true;
            }

            if (String.IsNullOrEmpty(COL_TB_banco.Text) && String.IsNullOrEmpty(COL_TB_nocuenta.Text) && String.IsNullOrEmpty(COL_TB_email.Text) && String.IsNullOrEmpty(COL_TB_phone.Text))
            {
                MessageBox.Show("Revise otros datos", "Colaborador", MessageBoxButtons.OK);
                otrosdatos = false;
            }
            else
            {
                datos.banco = COL_TB_banco.Text;
                datos.no_cuenta = COL_TB_nocuenta.Text;
                datos.email = COL_TB_email.Text;
                datos.telefono = COL_TB_phone.Text;
                otrosdatos = true;
            }

            if (String.IsNullOrEmpty(COL_TB_address.Text) && String.IsNullOrEmpty(COL_TB_estado.Text) && String.IsNullOrEmpty(COL_TB_municipio.Text) && String.IsNullOrEmpty(COL_TB_cp.Text))
            {
                MessageBox.Show("Revise los datos de direccion", "Colaborador", MessageBoxButtons.OK);
                datosdireccion = false;
            }
            else
            {
                datos.address = COL_TB_address.Text;
                datos.municipio = COL_TB_municipio.Text;
                datos.estado = COL_TB_estado.Text;
                datos.codigopostal = COL_TB_cp.Text;
                datosdireccion = true;
            }


            if (datosgenerales && otrosdatos && datosdireccion)
            {
                EnlaceCassandra cassandra = new EnlaceCassandra();
                bool col = cassandra.Agregar_colaborador(datos);
                if (col)
                {
                    COL_TB_nombre.ResetText();
                    COL_TB_password.ResetText();
                    COL_CB_departamento.ResetText();
                    COL_CB_puesto.ResetText();
                    COL_TB_bday.ResetText();
                    COL_TB_curp.ResetText();
                    COL_TB_nss.ResetText();
                    COL_TB_rfc.ResetText();
                    COL_TB_banco.ResetText();
                    COL_TB_nocuenta.ResetText();
                    COL_TB_email.ResetText();
                    COL_TB_phone.ResetText();
                    COL_TB_address.ResetText();
                    COL_TB_municipio.ResetText();
                    COL_TB_estado.ResetText();
                    COL_TB_cp.ResetText();
                    MessageBox.Show("Se agrego correctamente", "Colaborador", MessageBoxButtons.OK);
                }
            }
        }

        private void Alta_Colaboradores_Load(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var listadep = enlace.Get_departamento();
            if (listadep != null)
            {
                Datos_departamento departamento = new Datos_departamento();
                Guid guid = Guid.NewGuid();
                departamento.ID_dep = guid;
                departamento.ID_empresa = guid;
                departamento.name = " ";
                departamento.sueldobase = 0;
                listadep.Insert(0, departamento);
                COL_CB_departamento.DataSource = listadep;
                COL_CB_departamento.DisplayMember = "name";
                COL_CB_departamento.ValueMember = "name";
            }
            EnlaceCassandra cassandra = new EnlaceCassandra();
            var listapuesto = cassandra.Get_puesto();
            if (listapuesto != null)
            {
                Guid guid = Guid.NewGuid();
                Datos_puesto puesto = new Datos_puesto();
                puesto.ID_empresa = guid;
                puesto.ID_puesto = guid;
                puesto.name = " ";
                puesto.nivel_salarial = 0;
                listapuesto.Insert(0, puesto);
                COL_CB_puesto.DataSource = listapuesto;
                COL_CB_puesto.DisplayMember = "name";
                COL_CB_puesto.ValueMember = "name";
            }

        }
    }
}
