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

namespace MAD.contenedores_departamento
{
    public partial class CONT_DEP_up_del : UserControl
    {
        public Datos_departamento dep = new Datos_departamento();
        public CONT_DEP_up_del()
        {
            InitializeComponent();
            DEP_PANEL_modificar.Hide();
        }

        private void CONT_DEP_up_del_Load(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var lista = enlace.Get_departamento();
            if(lista != null)
            {
                TABLA_departamentos.DataSource = lista;
                TABLA_departamentos.Columns["Name"].HeaderText = "Nombre";
                TABLA_departamentos.Columns["sueldobase"].HeaderText = "Sueldo base";
                TABLA_departamentos.Columns["ID_dep"].HeaderText = "ID";
                TABLA_departamentos.Columns["ID_empresa"].Visible = false;
            }
            else{
                MessageBox.Show("Aun no hay departamentos dados de alta", "Departamento", MessageBoxButtons.OK);
            }

        }


        private void TABLA_departamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = TABLA_departamentos.Rows[e.RowIndex];
                TABLA_departamentos.CurrentRow.Selected = true;
                Guid ID_dep = Guid.Parse(TABLA_departamentos.Rows[e.RowIndex].Cells["ID_dep"].FormattedValue.ToString());
                EnlaceCassandra enlace = new EnlaceCassandra();
                DialogResult resultado = MessageBox.Show("¿Desea modificar el departamento?", "Departamento", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    DEP_PANEL_modificar.Show();
                    EnlaceCassandra cassandra = new EnlaceCassandra();
                    var lista = cassandra.Get_departamentoOneByIds(ID_dep);
                    foreach (var item in lista)
                    {
                        DEP_LABEL_nombre.Text = item.name;
                        DEP_LABEL_sb.Text = item.sueldobase.ToString();
                        dep.ID_dep = item.ID_dep;
                        dep.ID_empresa = item.ID_empresa;

                    }
                }
                else
                {

                }
            }
        }

        private void WADDE_BTN_re_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(DEP_LABEL_nombre.Text) && String.IsNullOrEmpty(DEP_LABEL_sb.Text))
            {
                MessageBox.Show("Por favor llena todo los campos", "Departamento", MessageBoxButtons.OK);
            }
            else
            {
                dep.name = DEP_LABEL_nombre.Text;
                dep.sueldobase = float.Parse(DEP_LABEL_sb.Text);
                EnlaceCassandra cas = new EnlaceCassandra();
                bool sionel = cas.update_departamento(dep);
                if (sionel)
                {
                    DEP_LABEL_nombre.ResetText();
                    DEP_LABEL_sb.ResetText();
                }
            }

        }
    }
}
