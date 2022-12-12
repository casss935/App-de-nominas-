using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.contenedores_colaborador;

namespace MAD.contenedores
{
    public partial class ID_colaboradores : UserControl
    {
        public ID_colaboradores()
        {
            InitializeComponent();
            Alta_Colaboradores _Colaboradores = new Alta_Colaboradores();
            AddContenedores_Colaboradores(_Colaboradores);
        }
        private void AddContenedores_Colaboradores(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            COL_CONT_panel.Controls.Clear();
            COL_CONT_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Col_Button_altas_Click(object sender, EventArgs e)
        {
            Alta_Colaboradores _Colaboradores = new Alta_Colaboradores();
            AddContenedores_Colaboradores(_Colaboradores);
        }

        private void Col_Buttom_modificar_Click(object sender, EventArgs e)
        {
            Update_Colaborador update = new Update_Colaborador();
            AddContenedores_Colaboradores(update);
        }

        private void Col_Button_eliminar_Click(object sender, EventArgs e)
        {
            Baja_Colaborador baja_Colaborador = new Baja_Colaborador();
            AddContenedores_Colaboradores(baja_Colaborador);
        }
    }
}
