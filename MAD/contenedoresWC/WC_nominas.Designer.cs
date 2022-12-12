
namespace MAD.contenedoresWC
{
    partial class WC_nominas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.WC_Button_Nom_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WC_Button_Nom_descargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar nominas:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre ",
            "Octubre",
            "Noviembre ",
            "Diciembre"});
            this.listBox1.Location = new System.Drawing.Point(270, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 24);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.listBox2.Location = new System.Drawing.Point(412, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(127, 24);
            this.listBox2.TabIndex = 2;
            // 
            // WC_Button_Nom_buscar
            // 
            this.WC_Button_Nom_buscar.Location = new System.Drawing.Point(571, 22);
            this.WC_Button_Nom_buscar.Name = "WC_Button_Nom_buscar";
            this.WC_Button_Nom_buscar.Size = new System.Drawing.Size(75, 23);
            this.WC_Button_Nom_buscar.TabIndex = 3;
            this.WC_Button_Nom_buscar.Text = "Buscar";
            this.WC_Button_Nom_buscar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(141, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 370);
            this.panel1.TabIndex = 4;
            // 
            // WC_Button_Nom_descargar
            // 
            this.WC_Button_Nom_descargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC_Button_Nom_descargar.Location = new System.Drawing.Point(345, 448);
            this.WC_Button_Nom_descargar.Name = "WC_Button_Nom_descargar";
            this.WC_Button_Nom_descargar.Size = new System.Drawing.Size(94, 36);
            this.WC_Button_Nom_descargar.TabIndex = 5;
            this.WC_Button_Nom_descargar.Text = "Descargar";
            this.WC_Button_Nom_descargar.UseVisualStyleBackColor = true;
            // 
            // WC_nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WC_Button_Nom_descargar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WC_Button_Nom_buscar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "WC_nominas";
            this.Size = new System.Drawing.Size(800, 512);
            this.Load += new System.EventHandler(this.WC_nominas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button WC_Button_Nom_buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WC_Button_Nom_descargar;
    }
}
