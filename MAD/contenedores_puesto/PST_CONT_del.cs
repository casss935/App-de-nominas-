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

namespace MAD.contenedores_puesto
{
    public partial class PST_CONT_del : UserControl
    {
        Datos_puesto Puesto = new Datos_puesto();
        public PST_CONT_del()
        {
            InitializeComponent();
        }

        private void PST_CONT_del_Load(object sender, EventArgs e)
        {
            EnlaceCassandra cassandra = new EnlaceCassandra();
            var lista = cassandra.Get_puesto();
            if (lista != null)
            {
                TABLA_puestos.DataSource = lista;
                TABLA_puestos.Columns["name"].HeaderText = "Nombre";
                TABLA_puestos.Columns["nivel_salarial"].HeaderText = "Nivel salarial";
                TABLA_puestos.Columns["ID_puesto"].Visible = false;
                TABLA_puestos.Columns["ID_empresa"].Visible = false;

            }
        }

        private void TABLA_puestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = TABLA_puestos.Rows[e.RowIndex];
            TABLA_puestos.CurrentRow.Selected = true;
            Puesto.ID_puesto = Guid.Parse(TABLA_puestos.Rows[e.RowIndex].Cells["ID_puesto"].FormattedValue.ToString());
            Puesto.ID_empresa = statics.ID_empresa;
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el puesto?", "púesto", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                EnlaceCassandra enlaceCassandra = new EnlaceCassandra();
                bool sionel = enlaceCassandra.Delete_puesto(Puesto);
                if (sionel)
                {
                    MessageBox.Show("El puesto se elimino correctamente", "Puesto", MessageBoxButtons.OK);
                }

            }
            else
            {

            }

        }
    }
}
