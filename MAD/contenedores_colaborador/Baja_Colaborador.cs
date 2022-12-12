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

namespace MAD.contenedores_colaborador
{
    public partial class Baja_Colaborador : UserControl
    {
        public string id_makde;
        public Guid id_numero;

        public Baja_Colaborador()
        {
            InitializeComponent();
            DEL_panel_col.Hide();
        }

        private void DEL_COL_BTN_rfc_Click(object sender, EventArgs e)
        {
            DEL_panel_col.Show();
            EnlaceCassandra cassandra = new EnlaceCassandra();            
            string rfc = UP_LABEL_rfc.Text;
            var lista = cassandra.GetAllColaboradores();
            foreach( var item in lista)                
            {
                if(rfc == item.rfc)
                {
                    COL_TB_nombre.Text = item.name;
                    COL_TB_departamento.Text = item.departamento;
                    COL_TB_puesto.Text = item.puesto;
                    COL_TB_curp.Text = item.curp;
                    COL_TB_nss.Text = item.nss;
                    COL_TB_rfc.Text = item.rfc;
                    id_numero = item.ID_numero;
                    break;
                }


            }


        }

        private void DEL_BTN_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el empleado seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {                
                EnlaceCassandra enlace = new EnlaceCassandra();
                bool sionel = enlace.Delete_empleado(id_numero);
                if (sionel)
                {
                    UP_LABEL_rfc.ResetText();
                    COL_TB_nombre.ResetText();
                    COL_TB_departamento.ResetText();
                    COL_TB_puesto.ResetText();
                    COL_TB_curp.ResetText();
                    COL_TB_nss.ResetText();
                    COL_TB_rfc.ResetText();
                    DEL_panel_col.Show();
                    MessageBox.Show("Se elimino correctamente", "Colaborador", MessageBoxButtons.OK);
                }

            }

        }
    }
}
