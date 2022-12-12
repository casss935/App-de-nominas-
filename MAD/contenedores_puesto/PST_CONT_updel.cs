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
    
    public partial class PST_CONT_updel : UserControl
    {
        public PST_CONT_updel()
        {
            InitializeComponent();
            PST_up_panel.Hide();
            PST_BTN_update.Hide();
        }
        public Datos_puesto Puesto = new Datos_puesto();

        private void PST_CONT_updel_Load(object sender, EventArgs e)
        {
            EnlaceCassandra cassandra = new EnlaceCassandra();
            var lista = cassandra.Get_puesto();
            if(lista != null)
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
            DialogResult resultado = MessageBox.Show("¿Desea modificar el puesto?", "púesto", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                PST_up_panel.Show();
                PST_BTN_update.Show();
                EnlaceCassandra cassandra = new EnlaceCassandra();
                var lista = cassandra.Get_OnePuesto(Puesto);
                foreach (var item in lista)
                {
                    PST_TB_name.Text = item.name;
                    PST_TB_ns.Text = item.nivel_salarial.ToString();

                }
            }
            else
            {

            }

        }

        private void PST_BTN_update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PST_TB_name.Text) && String.IsNullOrEmpty(PST_TB_ns.Text)){
                MessageBox.Show("Por favor llena todo los campos", "Puesto", MessageBoxButtons.OK);
            }
            else
            {
                Puesto.name = PST_TB_name.Text;
                Puesto.nivel_salarial = float.Parse(PST_TB_ns.Text);
                EnlaceCassandra cassandra = new EnlaceCassandra();
                bool sionel = cassandra.update_puesto(Puesto);
                if(sionel)
                {
                    MessageBox.Show("La informacion se actualizo correctamente", "Departamento", MessageBoxButtons.OK);
                }

            }
        }
    }
}
