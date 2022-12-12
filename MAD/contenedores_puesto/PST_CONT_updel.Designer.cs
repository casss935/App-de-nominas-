
namespace MAD.contenedores_puesto
{
    partial class PST_CONT_updel
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
            this.label2 = new System.Windows.Forms.Label();
            this.TABLA_puestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PST_up_panel = new System.Windows.Forms.Panel();
            this.PST_TB_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PST_TB_ns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PST_BTN_update = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_puestos)).BeginInit();
            this.PST_up_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(313, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccione el puesto";
            // 
            // TABLA_puestos
            // 
            this.TABLA_puestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLA_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_puestos.Location = new System.Drawing.Point(163, 104);
            this.TABLA_puestos.Name = "TABLA_puestos";
            this.TABLA_puestos.ReadOnly = true;
            this.TABLA_puestos.Size = new System.Drawing.Size(474, 283);
            this.TABLA_puestos.TabIndex = 19;
            this.TABLA_puestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_puestos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modificar puesto";
            // 
            // PST_up_panel
            // 
            this.PST_up_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PST_up_panel.Controls.Add(this.PST_TB_name);
            this.PST_up_panel.Controls.Add(this.label3);
            this.PST_up_panel.Controls.Add(this.PST_TB_ns);
            this.PST_up_panel.Controls.Add(this.label5);
            this.PST_up_panel.Location = new System.Drawing.Point(100, 99);
            this.PST_up_panel.Name = "PST_up_panel";
            this.PST_up_panel.Size = new System.Drawing.Size(600, 288);
            this.PST_up_panel.TabIndex = 21;
            // 
            // PST_TB_name
            // 
            this.PST_TB_name.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PST_TB_name.Location = new System.Drawing.Point(215, 100);
            this.PST_TB_name.Name = "PST_TB_name";
            this.PST_TB_name.Size = new System.Drawing.Size(240, 29);
            this.PST_TB_name.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nivel salarial:";
            // 
            // PST_TB_ns
            // 
            this.PST_TB_ns.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PST_TB_ns.Location = new System.Drawing.Point(215, 153);
            this.PST_TB_ns.Name = "PST_TB_ns";
            this.PST_TB_ns.Size = new System.Drawing.Size(240, 29);
            this.PST_TB_ns.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre:";
            // 
            // PST_BTN_update
            // 
            this.PST_BTN_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PST_BTN_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PST_BTN_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PST_BTN_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PST_BTN_update.FillColor = System.Drawing.Color.White;
            this.PST_BTN_update.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PST_BTN_update.ForeColor = System.Drawing.Color.Black;
            this.PST_BTN_update.Location = new System.Drawing.Point(292, 319);
            this.PST_BTN_update.Name = "PST_BTN_update";
            this.PST_BTN_update.Size = new System.Drawing.Size(217, 45);
            this.PST_BTN_update.TabIndex = 22;
            this.PST_BTN_update.Text = "Actualizar datos";
            this.PST_BTN_update.Click += new System.EventHandler(this.PST_BTN_update_Click);
            // 
            // PST_CONT_updel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PST_BTN_update);
            this.Controls.Add(this.PST_up_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TABLA_puestos);
            this.Controls.Add(this.label1);
            this.Name = "PST_CONT_updel";
            this.Size = new System.Drawing.Size(800, 431);
            this.Load += new System.EventHandler(this.PST_CONT_updel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_puestos)).EndInit();
            this.PST_up_panel.ResumeLayout(false);
            this.PST_up_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TABLA_puestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PST_up_panel;
        private System.Windows.Forms.TextBox PST_TB_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PST_TB_ns;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button PST_BTN_update;
    }
}
