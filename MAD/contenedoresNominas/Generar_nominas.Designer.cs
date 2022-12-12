
namespace MAD.contenedoresNominas
{
    partial class WN_Generar_nominas
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
            this.NMN_BTN_delete = new Guna.UI2.WinForms.Guna2Button();
            this.NMN_BTN_comprobar = new Guna.UI2.WinForms.Guna2Button();
            this.NMN_BTN_gnomina = new Guna.UI2.WinForms.Guna2Button();
            this.NMN_PANEL_home = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NMN_BTN_delete
            // 
            this.NMN_BTN_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NMN_BTN_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NMN_BTN_delete.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMN_BTN_delete.ForeColor = System.Drawing.Color.White;
            this.NMN_BTN_delete.Location = new System.Drawing.Point(533, 0);
            this.NMN_BTN_delete.Name = "NMN_BTN_delete";
            this.NMN_BTN_delete.Size = new System.Drawing.Size(267, 37);
            this.NMN_BTN_delete.TabIndex = 26;
            this.NMN_BTN_delete.Text = "Eliminar";
            this.NMN_BTN_delete.Click += new System.EventHandler(this.NMN_BTN_delete_Click);
            // 
            // NMN_BTN_comprobar
            // 
            this.NMN_BTN_comprobar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_comprobar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_comprobar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NMN_BTN_comprobar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NMN_BTN_comprobar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMN_BTN_comprobar.ForeColor = System.Drawing.Color.White;
            this.NMN_BTN_comprobar.Location = new System.Drawing.Point(267, 0);
            this.NMN_BTN_comprobar.Name = "NMN_BTN_comprobar";
            this.NMN_BTN_comprobar.Size = new System.Drawing.Size(266, 37);
            this.NMN_BTN_comprobar.TabIndex = 25;
            this.NMN_BTN_comprobar.Text = "Comprobar ";
            this.NMN_BTN_comprobar.Click += new System.EventHandler(this.NMN_BTN_comprobar_Click);
            // 
            // NMN_BTN_gnomina
            // 
            this.NMN_BTN_gnomina.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_gnomina.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NMN_BTN_gnomina.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NMN_BTN_gnomina.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NMN_BTN_gnomina.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMN_BTN_gnomina.ForeColor = System.Drawing.Color.White;
            this.NMN_BTN_gnomina.Location = new System.Drawing.Point(0, 0);
            this.NMN_BTN_gnomina.Name = "NMN_BTN_gnomina";
            this.NMN_BTN_gnomina.Size = new System.Drawing.Size(267, 37);
            this.NMN_BTN_gnomina.TabIndex = 24;
            this.NMN_BTN_gnomina.Text = "Generar Nomina";
            this.NMN_BTN_gnomina.Click += new System.EventHandler(this.NMN_BTN_gnomina_Click);
            // 
            // NMN_PANEL_home
            // 
            this.NMN_PANEL_home.Location = new System.Drawing.Point(0, 33);
            this.NMN_PANEL_home.Name = "NMN_PANEL_home";
            this.NMN_PANEL_home.Size = new System.Drawing.Size(800, 449);
            this.NMN_PANEL_home.TabIndex = 27;
            // 
            // WN_Generar_nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NMN_PANEL_home);
            this.Controls.Add(this.NMN_BTN_delete);
            this.Controls.Add(this.NMN_BTN_comprobar);
            this.Controls.Add(this.NMN_BTN_gnomina);
            this.Name = "WN_Generar_nominas";
            this.Size = new System.Drawing.Size(800, 482);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button NMN_BTN_delete;
        private Guna.UI2.WinForms.Guna2Button NMN_BTN_comprobar;
        private Guna.UI2.WinForms.Guna2Button NMN_BTN_gnomina;
        private System.Windows.Forms.Panel NMN_PANEL_home;
    }
}
