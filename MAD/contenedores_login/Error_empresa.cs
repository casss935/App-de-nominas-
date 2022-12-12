using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD.contenedores_login
{
    public partial class WD_ID_Error_empresa : UserControl
    {
        public WD_ID_Error_empresa()
        {
            InitializeComponent();
        }

        private void Login_BTN_addbuss_Click(object sender, EventArgs e)
        {
            Add_empresa add_Empresa = new Add_empresa();
            add_Empresa.Show();
        }
    }
}
