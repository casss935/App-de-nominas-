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

namespace MAD.contenedores_departamento
{
    public partial class CONT_DEP_delete : UserControl
    {
        public CONT_DEP_delete()
        {
            InitializeComponent();
        }

        private void CONT_DEP_delete_Load(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var lista = enlace.Get_departamento();
            if(lista != null)
            {
                DEL_TABLA_dep.DataSource = lista;
                DEL_TABLA_dep.Columns["name"].HeaderText = "Nombre";
                DEL_TABLA_dep.Columns["sueldobase"].HeaderText = "Sueldo base";
                DEL_TABLA_dep.Columns["ID_dep"].HeaderText = "ID";
                DEL_TABLA_dep.Columns["ID_empresa"].Visible = false;
            }
            else
            {
                MessageBox.Show("Aun no hay departamentos dados de alta", "Departamento", MessageBoxButtons.OK);
            }

        }

        private void DEL_TABLA_dep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DEL_TABLA_dep.Rows[e.RowIndex];
                DEL_TABLA_dep.CurrentRow.Selected = true;
                Guid ID_dep = Guid.Parse(DEL_TABLA_dep.Rows[e.RowIndex].Cells["ID_dep"].FormattedValue.ToString());
                string name = DEL_TABLA_dep.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                EnlaceCassandra enlace = new EnlaceCassandra();
                DialogResult resultado = MessageBox.Show("¿Que desea eliminar el departamento junto con todos sus empleados?", "Departamento", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    EnlaceCassandra cassandra = new EnlaceCassandra();
                    cassandra.Delete_departamento(ID_dep);
                }
                else
                {

                }



            }
        }
    }
}
