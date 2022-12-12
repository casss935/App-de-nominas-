using MAD.contenedoresWC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class WindowColaborador : Form
    {
        public WindowColaborador()
        {
            InitializeComponent();
            WC_inicio WC = new WC_inicio();
            AddContenedoresColb(WC);            
        }
        private void AddContenedoresColb(UserControl userControlColb)
        {
            userControlColb.Dock = DockStyle.Fill;
            WC_Panel_contenedor.Controls.Clear();
            WC_Panel_contenedor.Controls.Add(userControlColb);
            userControlColb.BringToFront();

        }

        private void WC_button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WC_id_buttoninicio_Click(object sender, EventArgs e)
        {
            WC_inicio WC = new WC_inicio();
            AddContenedoresColb(WC);
        }

        private void WC_id_buttonnominas_Click(object sender, EventArgs e)
        {
            WC_nominas WC = new WC_nominas();
            AddContenedoresColb(WC);
        }

        private void WC_id_buttoncolaboradores_Click(object sender, EventArgs e)
        {
            WC_DatosPersonales WC = new WC_DatosPersonales();
            AddContenedoresColb(WC);
        }
    }
}
