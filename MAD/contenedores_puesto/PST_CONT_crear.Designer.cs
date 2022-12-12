
namespace MAD.contenedores_puesto
{
    partial class PST_CONT_crear
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
            this.WADDE_BTN_re = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PST_TB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PST_TB_ns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WADDE_BTN_re
            // 
            this.WADDE_BTN_re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WADDE_BTN_re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WADDE_BTN_re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WADDE_BTN_re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WADDE_BTN_re.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.WADDE_BTN_re.ForeColor = System.Drawing.Color.White;
            this.WADDE_BTN_re.Location = new System.Drawing.Point(292, 357);
            this.WADDE_BTN_re.Name = "WADDE_BTN_re";
            this.WADDE_BTN_re.Size = new System.Drawing.Size(217, 45);
            this.WADDE_BTN_re.TabIndex = 19;
            this.WADDE_BTN_re.Text = "Registrar puesto";
            this.WADDE_BTN_re.Click += new System.EventHandler(this.WADDE_BTN_re_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.PST_TB_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PST_TB_ns);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(100, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 228);
            this.panel1.TabIndex = 18;
            // 
            // PST_TB_name
            // 
            this.PST_TB_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PST_TB_name.Location = new System.Drawing.Point(215, 63);
            this.PST_TB_name.Name = "PST_TB_name";
            this.PST_TB_name.Size = new System.Drawing.Size(240, 29);
            this.PST_TB_name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nivel salarial:";
            // 
            // PST_TB_ns
            // 
            this.PST_TB_ns.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PST_TB_ns.Location = new System.Drawing.Point(215, 116);
            this.PST_TB_ns.Name = "PST_TB_ns";
            this.PST_TB_ns.Size = new System.Drawing.Size(240, 29);
            this.PST_TB_ns.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(310, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Agregar un puesto";
            // 
            // PST_CONT_crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WADDE_BTN_re);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "PST_CONT_crear";
            this.Size = new System.Drawing.Size(800, 431);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button WADDE_BTN_re;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PST_TB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PST_TB_ns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
