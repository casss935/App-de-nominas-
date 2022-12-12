
namespace MAD.contenedoresHome
{
    partial class HOME_adddepartamento
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
            this.DEP_BTN_crear = new Guna.UI2.WinForms.Guna2Button();
            this.DEP_BTN_update = new Guna.UI2.WinForms.Guna2Button();
            this.DEP_PANEL_home = new System.Windows.Forms.Panel();
            this.DEP_BTN_delete = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // DEP_BTN_crear
            // 
            this.DEP_BTN_crear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_crear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_crear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEP_BTN_crear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEP_BTN_crear.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEP_BTN_crear.ForeColor = System.Drawing.Color.White;
            this.DEP_BTN_crear.Location = new System.Drawing.Point(0, 0);
            this.DEP_BTN_crear.Name = "DEP_BTN_crear";
            this.DEP_BTN_crear.Size = new System.Drawing.Size(267, 37);
            this.DEP_BTN_crear.TabIndex = 14;
            this.DEP_BTN_crear.Text = "Crear";
            this.DEP_BTN_crear.Click += new System.EventHandler(this.DEP_BTN_crear_Click);
            // 
            // DEP_BTN_update
            // 
            this.DEP_BTN_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEP_BTN_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEP_BTN_update.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEP_BTN_update.ForeColor = System.Drawing.Color.White;
            this.DEP_BTN_update.Location = new System.Drawing.Point(267, 0);
            this.DEP_BTN_update.Name = "DEP_BTN_update";
            this.DEP_BTN_update.Size = new System.Drawing.Size(266, 37);
            this.DEP_BTN_update.TabIndex = 15;
            this.DEP_BTN_update.Text = "Modificar";
            this.DEP_BTN_update.Click += new System.EventHandler(this.DEP_BTN_update_Click_1);
            // 
            // DEP_PANEL_home
            // 
            this.DEP_PANEL_home.Location = new System.Drawing.Point(0, 37);
            this.DEP_PANEL_home.Name = "DEP_PANEL_home";
            this.DEP_PANEL_home.Size = new System.Drawing.Size(800, 431);
            this.DEP_PANEL_home.TabIndex = 16;
            // 
            // DEP_BTN_delete
            // 
            this.DEP_BTN_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEP_BTN_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEP_BTN_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEP_BTN_delete.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEP_BTN_delete.ForeColor = System.Drawing.Color.White;
            this.DEP_BTN_delete.Location = new System.Drawing.Point(533, 0);
            this.DEP_BTN_delete.Name = "DEP_BTN_delete";
            this.DEP_BTN_delete.Size = new System.Drawing.Size(267, 37);
            this.DEP_BTN_delete.TabIndex = 17;
            this.DEP_BTN_delete.Text = "Eliminar";
            this.DEP_BTN_delete.Click += new System.EventHandler(this.DEP_BTN_delete_Click);
            // 
            // HOME_adddepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DEP_BTN_delete);
            this.Controls.Add(this.DEP_PANEL_home);
            this.Controls.Add(this.DEP_BTN_update);
            this.Controls.Add(this.DEP_BTN_crear);
            this.Name = "HOME_adddepartamento";
            this.Size = new System.Drawing.Size(800, 468);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button DEP_BTN_crear;
        private Guna.UI2.WinForms.Guna2Button DEP_BTN_update;
        private System.Windows.Forms.Panel DEP_PANEL_home;
        private Guna.UI2.WinForms.Guna2Button DEP_BTN_delete;
    }
}
