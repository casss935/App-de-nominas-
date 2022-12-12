
namespace MAD.contenedores_login
{
    partial class WD_ID_Error_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WD_ID_Error_empresa));
            this.Login_panel_addbuss = new System.Windows.Forms.Panel();
            this.Login_BTN_addbuss = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Login_PB_Error = new System.Windows.Forms.PictureBox();
            this.Login_panel_addbuss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PB_Error)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel_addbuss
            // 
            this.Login_panel_addbuss.BackColor = System.Drawing.Color.White;
            this.Login_panel_addbuss.Controls.Add(this.Login_BTN_addbuss);
            this.Login_panel_addbuss.Controls.Add(this.label5);
            this.Login_panel_addbuss.Location = new System.Drawing.Point(10, 16);
            this.Login_panel_addbuss.Name = "Login_panel_addbuss";
            this.Login_panel_addbuss.Size = new System.Drawing.Size(467, 92);
            this.Login_panel_addbuss.TabIndex = 15;
            // 
            // Login_BTN_addbuss
            // 
            this.Login_BTN_addbuss.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_addbuss.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_addbuss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_BTN_addbuss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_BTN_addbuss.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN_addbuss.ForeColor = System.Drawing.Color.White;
            this.Login_BTN_addbuss.Location = new System.Drawing.Point(172, 43);
            this.Login_BTN_addbuss.Name = "Login_BTN_addbuss";
            this.Login_BTN_addbuss.Size = new System.Drawing.Size(120, 34);
            this.Login_BTN_addbuss.TabIndex = 11;
            this.Login_BTN_addbuss.Text = "Dar de Alta";
            this.Login_BTN_addbuss.Click += new System.EventHandler(this.Login_BTN_addbuss_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(450, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "¡Actualmente no hay ninguna empresa dada de alta!";
            // 
            // Login_PB_Error
            // 
            this.Login_PB_Error.Image = ((System.Drawing.Image)(resources.GetObject("Login_PB_Error.Image")));
            this.Login_PB_Error.Location = new System.Drawing.Point(76, 134);
            this.Login_PB_Error.Name = "Login_PB_Error";
            this.Login_PB_Error.Size = new System.Drawing.Size(329, 256);
            this.Login_PB_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Login_PB_Error.TabIndex = 16;
            this.Login_PB_Error.TabStop = false;
            // 
            // WD_ID_Error_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Login_panel_addbuss);
            this.Controls.Add(this.Login_PB_Error);
            this.Name = "WD_ID_Error_empresa";
            this.Size = new System.Drawing.Size(489, 437);
            this.Login_panel_addbuss.ResumeLayout(false);
            this.Login_panel_addbuss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PB_Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel_addbuss;
        private Guna.UI2.WinForms.Guna2Button Login_BTN_addbuss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Login_PB_Error;
    }
}
