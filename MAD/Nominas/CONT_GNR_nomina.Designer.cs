
namespace MAD.Nominas
{
    partial class CONT_GNR_nomina
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
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GNNOM_BT_ded_aplicar = new System.Windows.Forms.Button();
            this.GNNOM_CB_ded = new System.Windows.Forms.ListBox();
            this.GNNOM_BTN_perc_aplicar = new System.Windows.Forms.Button();
            this.GNNOM_CB_perc = new System.Windows.Forms.ListBox();
            this.GNNOM_CB_dep_ded = new System.Windows.Forms.ListBox();
            this.GNNOM_CB_dep_perc = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GNNMN_TABLA_percp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GNNMN_TABLA_ded = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_mes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNNMN_TABLA_percp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNNMN_TABLA_ded)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(315, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 29;
            this.button3.Text = "Generar Nomina";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Deducciones aplicadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Percepciones aplicadas";
            // 
            // GNNOM_BT_ded_aplicar
            // 
            this.GNNOM_BT_ded_aplicar.Location = new System.Drawing.Point(283, 84);
            this.GNNOM_BT_ded_aplicar.Name = "GNNOM_BT_ded_aplicar";
            this.GNNOM_BT_ded_aplicar.Size = new System.Drawing.Size(75, 24);
            this.GNNOM_BT_ded_aplicar.TabIndex = 26;
            this.GNNOM_BT_ded_aplicar.Text = "Aplicar";
            this.GNNOM_BT_ded_aplicar.UseVisualStyleBackColor = true;
            this.GNNOM_BT_ded_aplicar.Click += new System.EventHandler(this.GNNOM_BT_ded_aplicar_Click);
            // 
            // GNNOM_CB_ded
            // 
            this.GNNOM_CB_ded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNNOM_CB_ded.FormattingEnabled = true;
            this.GNNOM_CB_ded.ItemHeight = 20;
            this.GNNOM_CB_ded.Location = new System.Drawing.Point(31, 84);
            this.GNNOM_CB_ded.Name = "GNNOM_CB_ded";
            this.GNNOM_CB_ded.Size = new System.Drawing.Size(246, 24);
            this.GNNOM_CB_ded.TabIndex = 25;
            // 
            // GNNOM_BTN_perc_aplicar
            // 
            this.GNNOM_BTN_perc_aplicar.Location = new System.Drawing.Point(278, 84);
            this.GNNOM_BTN_perc_aplicar.Name = "GNNOM_BTN_perc_aplicar";
            this.GNNOM_BTN_perc_aplicar.Size = new System.Drawing.Size(75, 24);
            this.GNNOM_BTN_perc_aplicar.TabIndex = 24;
            this.GNNOM_BTN_perc_aplicar.Text = "Aplicar";
            this.GNNOM_BTN_perc_aplicar.UseVisualStyleBackColor = true;
            this.GNNOM_BTN_perc_aplicar.Click += new System.EventHandler(this.GNNOM_BTN_perc_aplicar_Click);
            // 
            // GNNOM_CB_perc
            // 
            this.GNNOM_CB_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNNOM_CB_perc.FormattingEnabled = true;
            this.GNNOM_CB_perc.ItemHeight = 20;
            this.GNNOM_CB_perc.Location = new System.Drawing.Point(41, 84);
            this.GNNOM_CB_perc.Name = "GNNOM_CB_perc";
            this.GNNOM_CB_perc.Size = new System.Drawing.Size(231, 24);
            this.GNNOM_CB_perc.TabIndex = 23;
            // 
            // GNNOM_CB_dep_ded
            // 
            this.GNNOM_CB_dep_ded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNNOM_CB_dep_ded.FormattingEnabled = true;
            this.GNNOM_CB_dep_ded.ItemHeight = 20;
            this.GNNOM_CB_dep_ded.Location = new System.Drawing.Point(31, 54);
            this.GNNOM_CB_dep_ded.Name = "GNNOM_CB_dep_ded";
            this.GNNOM_CB_dep_ded.Size = new System.Drawing.Size(327, 24);
            this.GNNOM_CB_dep_ded.TabIndex = 21;
            // 
            // GNNOM_CB_dep_perc
            // 
            this.GNNOM_CB_dep_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNNOM_CB_dep_perc.FormattingEnabled = true;
            this.GNNOM_CB_dep_perc.ItemHeight = 20;
            this.GNNOM_CB_dep_perc.Location = new System.Drawing.Point(41, 54);
            this.GNNOM_CB_dep_perc.Name = "GNNOM_CB_dep_perc";
            this.GNNOM_CB_dep_perc.Size = new System.Drawing.Size(312, 24);
            this.GNNOM_CB_dep_perc.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(205, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 30);
            this.label15.TabIndex = 36;
            this.label15.Text = "Generar nomina";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.GNNMN_TABLA_percp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GNNOM_CB_dep_perc);
            this.panel1.Controls.Add(this.GNNOM_CB_perc);
            this.panel1.Controls.Add(this.GNNOM_BTN_perc_aplicar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 364);
            this.panel1.TabIndex = 37;
            // 
            // GNNMN_TABLA_percp
            // 
            this.GNNMN_TABLA_percp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GNNMN_TABLA_percp.Location = new System.Drawing.Point(14, 139);
            this.GNNMN_TABLA_percp.Name = "GNNMN_TABLA_percp";
            this.GNNMN_TABLA_percp.Size = new System.Drawing.Size(361, 214);
            this.GNNMN_TABLA_percp.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 47);
            this.label3.TabIndex = 28;
            this.label3.Text = "Seleccione la percepcion y el grupo al que se le aplicara ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.GNNMN_TABLA_ded);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GNNOM_CB_dep_ded);
            this.panel2.Controls.Add(this.GNNOM_CB_ded);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.GNNOM_BT_ded_aplicar);
            this.panel2.Location = new System.Drawing.Point(406, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 364);
            this.panel2.TabIndex = 38;
            // 
            // GNNMN_TABLA_ded
            // 
            this.GNNMN_TABLA_ded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GNNMN_TABLA_ded.Location = new System.Drawing.Point(12, 139);
            this.GNNMN_TABLA_ded.Name = "GNNMN_TABLA_ded";
            this.GNNMN_TABLA_ded.Size = new System.Drawing.Size(362, 214);
            this.GNNMN_TABLA_ded.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 47);
            this.label4.TabIndex = 29;
            this.label4.Text = "Seleccione la deduccion y el grupo al que se le aplicara ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // CB_mes
            // 
            this.CB_mes.FormattingEnabled = true;
            this.CB_mes.Items.AddRange(new object[] {
            "",
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JULIO",
            "JUNIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.CB_mes.Location = new System.Drawing.Point(394, 11);
            this.CB_mes.Name = "CB_mes";
            this.CB_mes.Size = new System.Drawing.Size(121, 21);
            this.CB_mes.TabIndex = 39;
            // 
            // CONT_GNR_nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CB_mes);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CONT_GNR_nomina";
            this.Size = new System.Drawing.Size(801, 460);
            this.Load += new System.EventHandler(this.CONT_GNR_nomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNNMN_TABLA_percp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNNMN_TABLA_ded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GNNOM_BT_ded_aplicar;
        private System.Windows.Forms.ListBox GNNOM_CB_ded;
        private System.Windows.Forms.Button GNNOM_BTN_perc_aplicar;
        private System.Windows.Forms.ListBox GNNOM_CB_perc;
        private System.Windows.Forms.ListBox GNNOM_CB_dep_ded;
        private System.Windows.Forms.ListBox GNNOM_CB_dep_perc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GNNMN_TABLA_percp;
        private System.Windows.Forms.DataGridView GNNMN_TABLA_ded;
        private System.Windows.Forms.ComboBox CB_mes;
    }
}
