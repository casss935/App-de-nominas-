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

namespace MAD.Nominas
{
    public partial class CONT_GNR_nomina : UserControl
    {

        List<Deducciones> lista_ded = new List<Deducciones>();
        List<Percepciones> lista_perc = new List<Percepciones>();
        public CONT_GNR_nomina()
        {
            InitializeComponent();
        }

        private void CONT_GNR_nomina_Load(object sender, EventArgs e)
        {
            EnlaceCassandra enlace = new EnlaceCassandra();
            var listperc = enlace.Get_percepcion();
            if (listperc != null)
            {
                Guid guid = Guid.NewGuid();
                Datos_pers pers = new Datos_pers();
                pers.ID_empresa = guid;
                pers.ID_percep = guid;
                pers.monto = 0;
                pers.name = " ";
                pers.tipo = "nada";
                listperc.Insert(0, pers);
                GNNOM_CB_perc.DataSource = listperc;
                GNNOM_CB_perc.DisplayMember = "name";
                GNNOM_CB_perc.ValueMember = "name";
            }
            EnlaceCassandra cassandra = new EnlaceCassandra();
            var listaded = cassandra.Get_deduccion();
            if(listaded != null)
            {
                Guid guid = Guid.NewGuid();
                Datos_deduccion deduccion = new Datos_deduccion();
                deduccion.ID_deduc = guid;
                deduccion.ID_empresa = guid;
                deduccion.monto = 0;
                deduccion.name = " ";
                deduccion.tipo = "nada";
                listaded.Insert(0, deduccion);
                GNNOM_CB_ded.DataSource = listaded;
                GNNOM_CB_ded.DisplayMember = "name";
                GNNOM_CB_ded.ValueMember = "name";
            }

            EnlaceCassandra datosdep1 = new EnlaceCassandra();
            var listadep1 = datosdep1.Get_departamento();
            if (listadep1 != null)
            {                
                Datos_departamento departamento = new Datos_departamento();
                Guid guid = Guid.NewGuid();
                departamento.ID_dep = guid;
                departamento.ID_empresa = guid;
                departamento.name = "Todos los departamentos";
                departamento.sueldobase = 0;
                listadep1.Insert(0, departamento);
                GNNOM_CB_dep_ded.DataSource = listadep1;
                GNNOM_CB_dep_ded.DisplayMember = "name";
                GNNOM_CB_dep_ded.ValueMember = "name";
            }
            EnlaceCassandra datosdep2 = new EnlaceCassandra();
            var listadep2 = datosdep2.Get_departamento();
            if (listadep2 != null)
            {
                Datos_departamento departamento = new Datos_departamento();
                Guid guid = Guid.NewGuid();
                departamento.ID_dep = guid;
                departamento.ID_empresa = guid;
                departamento.name = "Todos los departamentos";
                departamento.sueldobase = 0;
                listadep2.Insert(0, departamento);
                GNNOM_CB_dep_perc.DataSource = listadep2;
                GNNOM_CB_dep_perc.DisplayMember = "name";
                GNNOM_CB_dep_perc.ValueMember = "name";
            }

        }

        private void GNNOM_BTN_perc_aplicar_Click(object sender, EventArgs e)
        {
            if ((GNNOM_CB_perc.Text == " ") || (GNNOM_CB_dep_perc.Text == " "))
            {
                MessageBox.Show("Llene todos los campos", "Agregar percepciones", MessageBoxButtons.OK);
            }
            else
            {
                Percepciones percepciones = new Percepciones();
                percepciones.departamento = GNNOM_CB_dep_perc.Text;
                percepciones.name = GNNOM_CB_perc.Text;
                EnlaceCassandra cassandra = new EnlaceCassandra();
                var datos = cassandra.Get_percepcion();
                foreach(var item in datos)
                {
                    if(percepciones.name == item.name)
                    {
                        percepciones.ID_percep = item.ID_percep;
                        percepciones.monto = item.monto;
                        percepciones.fija = item.fija;
                        break;
                    }
                }
                bool sionel1 = lista_perc.Any();
                lista_perc.Add(percepciones);
                bool sionel = lista_perc.Any();
                actualizar_tabla_percepcion();
                
            }
        }

        private void GNNOM_BT_ded_aplicar_Click(object sender, EventArgs e)
        {            
            if ((GNNOM_CB_ded.Text == " ") || (GNNOM_CB_dep_ded.Text == " "))
            {
                MessageBox.Show("Llene todos los campos", "Agregar deducciones", MessageBoxButtons.OK);
            }
            else
            {
                Deducciones deducciones = new Deducciones();                
                deducciones.departamento = GNNOM_CB_dep_ded.Text;
                deducciones.name = GNNOM_CB_ded.Text;
                EnlaceCassandra enlace = new EnlaceCassandra();
                var datos = enlace.Get_deduccion();
                foreach( var item in datos)
                {
                    if(deducciones.name == item.name)
                    {
                        deducciones.fija = item.fija;
                        deducciones.ID_deduc = item.ID_deduc;
                        deducciones.monto = item.monto;
                        break;
                    }
                }
                lista_ded.Add(deducciones);
                actualizar_tabla_deducciones();
            }


        }
        private void actualizar_tabla_percepcion()
        {
            
            if (lista_perc.Any())
            {
                GNNMN_TABLA_percp.DataSource = null;
                GNNMN_TABLA_percp.DataSource = lista_perc;
                GNNMN_TABLA_percp.Columns["departamento"].HeaderText = "departamento";
                GNNMN_TABLA_percp.Columns["name"].HeaderText = "Nombre";
                GNNMN_TABLA_percp.Columns["monto"].HeaderText = "Monto";
                GNNMN_TABLA_percp.Columns["fija"].Visible = false;
                GNNMN_TABLA_percp.Columns["ID_percep"].Visible = false;
                
            }
            
        }

        private void actualizar_tabla_deducciones()
        {
            if (lista_ded.Any())
            {
                GNNMN_TABLA_ded.DataSource = null;
                GNNMN_TABLA_ded.DataSource = lista_ded;
                GNNMN_TABLA_ded.Columns["departamento"].HeaderText = "Departamento";
                GNNMN_TABLA_ded.Columns["name"].HeaderText = "Nombre";
                GNNMN_TABLA_ded.Columns["monto"].HeaderText = "Monto";
                GNNMN_TABLA_ded.Columns["fija"].Visible = false;
                GNNMN_TABLA_ded.Columns["ID_deduc"].Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mes = CB_mes.Text;
            decimal dias;
            if( mes == "ENERO" || mes == "MARZO" || mes == "MAYO" || mes == "JULIO" || mes == "AGOSTO" || mes == "OCTUBRE" || mes == "DICIEMBRE")
            {
                dias = 31;
            }
            if (mes == "FEBRERO")
            {
                dias = 28;
            }
            if (mes == "ABRIL" || mes == "JUNIO" || mes == "SEPTIEMBRE" || mes == "NOVIEMBRE")
            {
                dias = 30;
            }
            EnlaceCassandra cassandra = new EnlaceCassandra();
            var lista_de_empleados = cassandra.GetAllColaboradores();
            var lista_departamentos = cassandra.Get_departamento();
            var lista_puestos = cassandra.Get_puesto();
            var lista_percepciones = cassandra.Get_percepcion();
            var lista_deducciones = cassandra.Get_deduccion();
            foreach (var item in lista_de_empleados)
            {

                
            }



        }
    }
}
