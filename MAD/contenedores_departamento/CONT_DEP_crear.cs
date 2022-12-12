using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Clases;
using WindowsFormsApplication2;

namespace MAD.contenedores_departamento
{
    public partial class CONT_DEP_crear : UserControl
    {
        public CONT_DEP_crear()
        {
            InitializeComponent();
        }

        private void WADDE_BTN_re_Click(object sender, EventArgs e)
        {
            Datos_departamento departamento = new Datos_departamento();
            Guid ID = Guid.NewGuid();
            departamento.ID_dep = ID;
            departamento.ID_empresa = statics.ID_empresa;
            departamento.name = DEP_LABEL_nombre.Text;
            departamento.sueldobase = float.Parse(DEP_LABEL_sb.Text);
            EnlaceCassandra enlace = new EnlaceCassandra();
            bool dep= enlace.Agregar_departamento(departamento);
            if (dep)
            {
                DEP_LABEL_nombre.ResetText();
                DEP_LABEL_sb.ResetText();
                MessageBox.Show("Agregado correctamente", "Departamento", MessageBoxButtons.OK);
            }

        }
    }
}
