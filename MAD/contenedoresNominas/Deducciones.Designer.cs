
namespace MAD.contenedoresNominas
{
    partial class WN_deducciones
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
            this.DED_BTN_delete = new Guna.UI2.WinForms.Guna2Button();
            this.DED_BTN_update = new Guna.UI2.WinForms.Guna2Button();
            this.DED_BTN_alta = new Guna.UI2.WinForms.Guna2Button();
            this.DED_PANEL_home = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DED_BTN_delete
            // 
            this.DED_BTN_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DED_BTN_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DED_BTN_delete.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DED_BTN_delete.ForeColor = System.Drawing.Color.White;
            this.DED_BTN_delete.Location = new System.Drawing.Point(533, 0);
            this.DED_BTN_delete.Name = "DED_BTN_delete";
            this.DED_BTN_delete.Size = new System.Drawing.Size(267, 37);
            this.DED_BTN_delete.TabIndex = 23;
            this.DED_BTN_delete.Text = "Eliminar";
            this.DED_BTN_delete.Click += new System.EventHandler(this.DED_BTN_delete_Click);
            // 
            // DED_BTN_update
            // 
            this.DED_BTN_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DED_BTN_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DED_BTN_update.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DED_BTN_update.ForeColor = System.Drawing.Color.White;
            this.DED_BTN_update.Location = new System.Drawing.Point(267, 0);
            this.DED_BTN_update.Name = "DED_BTN_update";
            this.DED_BTN_update.Size = new System.Drawing.Size(266, 37);
            this.DED_BTN_update.TabIndex = 22;
            this.DED_BTN_update.Text = "Modificar";
            this.DED_BTN_update.Click += new System.EventHandler(this.DED_BTN_update_Click);
            // 
            // DED_BTN_alta
            // 
            this.DED_BTN_alta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_alta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DED_BTN_alta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DED_BTN_alta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DED_BTN_alta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DED_BTN_alta.ForeColor = System.Drawing.Color.White;
            this.DED_BTN_alta.Location = new System.Drawing.Point(0, 0);
            this.DED_BTN_alta.Name = "DED_BTN_alta";
            this.DED_BTN_alta.Size = new System.Drawing.Size(267, 37);
            this.DED_BTN_alta.TabIndex = 21;
            this.DED_BTN_alta.Text = "Crear";
            this.DED_BTN_alta.Click += new System.EventHandler(this.DED_BTN_alta_Click);
            // 
            // DED_PANEL_home
            // 
            this.DED_PANEL_home.Location = new System.Drawing.Point(0, 33);
            this.DED_PANEL_home.Name = "DED_PANEL_home";
            this.DED_PANEL_home.Size = new System.Drawing.Size(800, 449);
            this.DED_PANEL_home.TabIndex = 24;
            // 
            // WN_deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DED_PANEL_home);
            this.Controls.Add(this.DED_BTN_delete);
            this.Controls.Add(this.DED_BTN_update);
            this.Controls.Add(this.DED_BTN_alta);
            this.Name = "WN_deducciones";
            this.Size = new System.Drawing.Size(800, 482);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DED_BTN_delete;
        private Guna.UI2.WinForms.Guna2Button DED_BTN_update;
        private Guna.UI2.WinForms.Guna2Button DED_BTN_alta;
        private System.Windows.Forms.Panel DED_PANEL_home;
    }
}
