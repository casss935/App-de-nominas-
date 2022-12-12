
namespace MAD.contenedores_colaborador
{
    partial class Baja_Colaborador
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
            this.DEL_COL_BTN_rfc = new System.Windows.Forms.Button();
            this.UP_LABEL_rfc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DEL_panel_col = new System.Windows.Forms.Panel();
            this.DEL_BTN_eliminar = new System.Windows.Forms.Button();
            this.COL_TB_nss = new System.Windows.Forms.TextBox();
            this.COL_TB_rfc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.COL_TB_curp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.COL_TB_puesto = new System.Windows.Forms.TextBox();
            this.COL_TB_departamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COL_TB_nombre = new System.Windows.Forms.TextBox();
            this.DEL_panel_col.SuspendLayout();
            this.SuspendLayout();
            // 
            // DEL_COL_BTN_rfc
            // 
            this.DEL_COL_BTN_rfc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DEL_COL_BTN_rfc.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.DEL_COL_BTN_rfc.ForeColor = System.Drawing.Color.White;
            this.DEL_COL_BTN_rfc.Location = new System.Drawing.Point(521, 33);
            this.DEL_COL_BTN_rfc.Name = "DEL_COL_BTN_rfc";
            this.DEL_COL_BTN_rfc.Size = new System.Drawing.Size(83, 32);
            this.DEL_COL_BTN_rfc.TabIndex = 7;
            this.DEL_COL_BTN_rfc.Text = "Buscar";
            this.DEL_COL_BTN_rfc.UseVisualStyleBackColor = false;
            this.DEL_COL_BTN_rfc.Click += new System.EventHandler(this.DEL_COL_BTN_rfc_Click);
            // 
            // UP_LABEL_rfc
            // 
            this.UP_LABEL_rfc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UP_LABEL_rfc.Location = new System.Drawing.Point(296, 37);
            this.UP_LABEL_rfc.Name = "UP_LABEL_rfc";
            this.UP_LABEL_rfc.Size = new System.Drawing.Size(219, 25);
            this.UP_LABEL_rfc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(309, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eliminar colaborador";
            // 
            // DEL_panel_col
            // 
            this.DEL_panel_col.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DEL_panel_col.Controls.Add(this.DEL_BTN_eliminar);
            this.DEL_panel_col.Controls.Add(this.COL_TB_nss);
            this.DEL_panel_col.Controls.Add(this.COL_TB_rfc);
            this.DEL_panel_col.Controls.Add(this.label5);
            this.DEL_panel_col.Controls.Add(this.label6);
            this.DEL_panel_col.Controls.Add(this.label9);
            this.DEL_panel_col.Controls.Add(this.label10);
            this.DEL_panel_col.Controls.Add(this.COL_TB_curp);
            this.DEL_panel_col.Controls.Add(this.label11);
            this.DEL_panel_col.Controls.Add(this.COL_TB_puesto);
            this.DEL_panel_col.Controls.Add(this.COL_TB_departamento);
            this.DEL_panel_col.Controls.Add(this.label3);
            this.DEL_panel_col.Controls.Add(this.COL_TB_nombre);
            this.DEL_panel_col.Location = new System.Drawing.Point(176, 94);
            this.DEL_panel_col.Name = "DEL_panel_col";
            this.DEL_panel_col.Size = new System.Drawing.Size(461, 296);
            this.DEL_panel_col.TabIndex = 8;
            // 
            // DEL_BTN_eliminar
            // 
            this.DEL_BTN_eliminar.BackColor = System.Drawing.Color.White;
            this.DEL_BTN_eliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.DEL_BTN_eliminar.Location = new System.Drawing.Point(196, 239);
            this.DEL_BTN_eliminar.Name = "DEL_BTN_eliminar";
            this.DEL_BTN_eliminar.Size = new System.Drawing.Size(75, 30);
            this.DEL_BTN_eliminar.TabIndex = 49;
            this.DEL_BTN_eliminar.Text = "Eliminar";
            this.DEL_BTN_eliminar.UseVisualStyleBackColor = false;
            this.DEL_BTN_eliminar.Click += new System.EventHandler(this.DEL_BTN_eliminar_Click);
            // 
            // COL_TB_nss
            // 
            this.COL_TB_nss.Location = new System.Drawing.Point(242, 98);
            this.COL_TB_nss.Name = "COL_TB_nss";
            this.COL_TB_nss.Size = new System.Drawing.Size(195, 20);
            this.COL_TB_nss.TabIndex = 47;
            // 
            // COL_TB_rfc
            // 
            this.COL_TB_rfc.Location = new System.Drawing.Point(22, 139);
            this.COL_TB_rfc.Name = "COL_TB_rfc";
            this.COL_TB_rfc.Size = new System.Drawing.Size(214, 20);
            this.COL_TB_rfc.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(240, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Puesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(19, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "CURP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(239, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "NSS";
            // 
            // COL_TB_curp
            // 
            this.COL_TB_curp.Location = new System.Drawing.Point(22, 98);
            this.COL_TB_curp.Name = "COL_TB_curp";
            this.COL_TB_curp.Size = new System.Drawing.Size(214, 20);
            this.COL_TB_curp.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(19, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "RFC";
            // 
            // COL_TB_puesto
            // 
            this.COL_TB_puesto.Location = new System.Drawing.Point(242, 57);
            this.COL_TB_puesto.Name = "COL_TB_puesto";
            this.COL_TB_puesto.Size = new System.Drawing.Size(195, 20);
            this.COL_TB_puesto.TabIndex = 43;
            // 
            // COL_TB_departamento
            // 
            this.COL_TB_departamento.Location = new System.Drawing.Point(22, 57);
            this.COL_TB_departamento.Name = "COL_TB_departamento";
            this.COL_TB_departamento.Size = new System.Drawing.Size(214, 20);
            this.COL_TB_departamento.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre(s) / Apellido(s)";
            // 
            // COL_TB_nombre
            // 
            this.COL_TB_nombre.Location = new System.Drawing.Point(22, 16);
            this.COL_TB_nombre.Name = "COL_TB_nombre";
            this.COL_TB_nombre.Size = new System.Drawing.Size(415, 20);
            this.COL_TB_nombre.TabIndex = 16;
            // 
            // Baja_Colaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DEL_panel_col);
            this.Controls.Add(this.DEL_COL_BTN_rfc);
            this.Controls.Add(this.UP_LABEL_rfc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Baja_Colaborador";
            this.Size = new System.Drawing.Size(800, 480);
            this.DEL_panel_col.ResumeLayout(false);
            this.DEL_panel_col.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DEL_COL_BTN_rfc;
        private System.Windows.Forms.TextBox UP_LABEL_rfc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DEL_panel_col;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox COL_TB_nombre;
        private System.Windows.Forms.TextBox COL_TB_nss;
        private System.Windows.Forms.TextBox COL_TB_rfc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox COL_TB_puesto;
        private System.Windows.Forms.TextBox COL_TB_departamento;
        private System.Windows.Forms.Button DEL_BTN_eliminar;
        private System.Windows.Forms.TextBox COL_TB_curp;
    }
}
