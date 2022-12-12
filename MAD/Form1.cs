using MAD.contenedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;

namespace MAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ID_inicio ID = new ID_inicio();
            AddContenedores(ID);

        }

        private void AddContenedores(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ContenedorHome.Controls.Clear();
            ContenedorHome.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void id_buttonreportes_Click(object sender, EventArgs e)
        {
            ID_reportes ID = new ID_reportes();
            AddContenedores(ID);
        }
        private void id_buttoninicio_Click(object sender, EventArgs e)
        {
            ID_inicio ID = new ID_inicio();
            AddContenedores(ID);
        }

        private void id_buttonnominas_Click(object sender, EventArgs e)
        {
            ID_nominas ID = new ID_nominas();
            AddContenedores(ID);           
        }

        private void id_buttoncolaboradores_Click(object sender, EventArgs e)
        {
            ID_colaboradores ID = new ID_colaboradores();
            AddContenedores(ID);
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_maxi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
