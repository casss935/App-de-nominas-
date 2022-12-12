
namespace MAD.contenedores_departamento
{
    partial class CONT_DEP_up_del
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
            this.TABLA_departamentos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DEP_PANEL_modificar = new System.Windows.Forms.Panel();
            this.WADDE_BTN_re = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DEP_LABEL_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DEP_LABEL_sb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_departamentos)).BeginInit();
            this.DEP_PANEL_modificar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(253, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modificar departamento ";
            // 
            // TABLA_departamentos
            // 
            this.TABLA_departamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLA_departamentos.Location = new System.Drawing.Point(163, 104);
            this.TABLA_departamentos.Name = "TABLA_departamentos";
            this.TABLA_departamentos.ReadOnly = true;
            this.TABLA_departamentos.Size = new System.Drawing.Size(474, 283);
            this.TABLA_departamentos.TabIndex = 16;
            this.TABLA_departamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_departamentos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(283, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccione el departamento";
            // 
            // DEP_PANEL_modificar
            // 
            this.DEP_PANEL_modificar.Controls.Add(this.WADDE_BTN_re);
            this.DEP_PANEL_modificar.Controls.Add(this.panel2);
            this.DEP_PANEL_modificar.Location = new System.Drawing.Point(100, 64);
            this.DEP_PANEL_modificar.Name = "DEP_PANEL_modificar";
            this.DEP_PANEL_modificar.Size = new System.Drawing.Size(600, 323);
            this.DEP_PANEL_modificar.TabIndex = 18;
            // 
            // WADDE_BTN_re
            // 
            this.WADDE_BTN_re.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WADDE_BTN_re.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WADDE_BTN_re.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WADDE_BTN_re.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WADDE_BTN_re.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.WADDE_BTN_re.ForeColor = System.Drawing.Color.White;
            this.WADDE_BTN_re.Location = new System.Drawing.Point(196, 251);
            this.WADDE_BTN_re.Name = "WADDE_BTN_re";
            this.WADDE_BTN_re.Size = new System.Drawing.Size(217, 45);
            this.WADDE_BTN_re.TabIndex = 18;
            this.WADDE_BTN_re.Text = "Actualizar datos";
            this.WADDE_BTN_re.Click += new System.EventHandler(this.WADDE_BTN_re_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.DEP_LABEL_nombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DEP_LABEL_sb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 201);
            this.panel2.TabIndex = 17;
            // 
            // DEP_LABEL_nombre
            // 
            this.DEP_LABEL_nombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DEP_LABEL_nombre.Location = new System.Drawing.Point(215, 63);
            this.DEP_LABEL_nombre.Name = "DEP_LABEL_nombre";
            this.DEP_LABEL_nombre.Size = new System.Drawing.Size(240, 29);
            this.DEP_LABEL_nombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sueldo base:";
            // 
            // DEP_LABEL_sb
            // 
            this.DEP_LABEL_sb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DEP_LABEL_sb.Location = new System.Drawing.Point(215, 95);
            this.DEP_LABEL_sb.Name = "DEP_LABEL_sb";
            this.DEP_LABEL_sb.Size = new System.Drawing.Size(240, 29);
            this.DEP_LABEL_sb.TabIndex = 17;
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
            // CONT_DEP_up_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DEP_PANEL_modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TABLA_departamentos);
            this.Controls.Add(this.label1);
            this.Name = "CONT_DEP_up_del";
            this.Size = new System.Drawing.Size(800, 431);
            this.Load += new System.EventHandler(this.CONT_DEP_up_del_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_departamentos)).EndInit();
            this.DEP_PANEL_modificar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TABLA_departamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DEP_PANEL_modificar;
        private Guna.UI2.WinForms.Guna2Button WADDE_BTN_re;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DEP_LABEL_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DEP_LABEL_sb;
        private System.Windows.Forms.Label label5;
    }
}
