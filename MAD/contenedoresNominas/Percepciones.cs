using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.contenedor_deducciones;

namespace MAD.contenedoresNominas
{
    public partial class WN_percepciones : UserControl
    {
        public WN_percepciones()
        {
            InitializeComponent();
            PERS_CONT_alta alta = new PERS_CONT_alta();
            AddContenedores_pers(alta);

        }
        private void AddContenedores_pers(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PERS_PANEL_home.Controls.Clear();
            PERS_PANEL_home.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void PERS_BTN_alta_Click(object sender, EventArgs e)
        {
            PERS_CONT_alta alta = new PERS_CONT_alta();
            AddContenedores_pers(alta);

        }

        private void PERS_BTN_update_Click(object sender, EventArgs e)
        {
            PERS_CONT_modificar modificar = new PERS_CONT_modificar();
            AddContenedores_pers(modificar);
        }

        private void PERS_BTN_delete_Click(object sender, EventArgs e)
        {
            PERS_CONT_delete delete = new PERS_CONT_delete();
            AddContenedores_pers(delete);
        }
    }
}
