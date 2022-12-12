
namespace MAD
{
    partial class Window_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_mini = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button_maxi = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button_close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PANEL_CONTENEDORES_login = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button_mini);
            this.panel1.Controls.Add(this.button_maxi);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 50);
            this.panel1.TabIndex = 1;
            // 
            // button_mini
            // 
            this.button_mini.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_mini.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_mini.Image = ((System.Drawing.Image)(resources.GetObject("button_mini.Image")));
            this.button_mini.ImageOffset = new System.Drawing.Point(0, 0);
            this.button_mini.ImageRotate = 0F;
            this.button_mini.ImageSize = new System.Drawing.Size(24, 24);
            this.button_mini.Location = new System.Drawing.Point(415, 8);
            this.button_mini.Name = "button_mini";
            this.button_mini.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_mini.Size = new System.Drawing.Size(24, 24);
            this.button_mini.TabIndex = 2;
            // 
            // button_maxi
            // 
            this.button_maxi.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_maxi.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_maxi.Image = ((System.Drawing.Image)(resources.GetObject("button_maxi.Image")));
            this.button_maxi.ImageOffset = new System.Drawing.Point(0, 0);
            this.button_maxi.ImageRotate = 0F;
            this.button_maxi.ImageSize = new System.Drawing.Size(24, 24);
            this.button_maxi.Location = new System.Drawing.Point(439, 0);
            this.button_maxi.Name = "button_maxi";
            this.button_maxi.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_maxi.Size = new System.Drawing.Size(24, 24);
            this.button_maxi.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_close.FillColor = System.Drawing.Color.Transparent;
            this.button_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(463, 0);
            this.button_close.Name = "button_close";
            this.button_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.button_close.Size = new System.Drawing.Size(24, 24);
            this.button_close.TabIndex = 0;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // PANEL_CONTENEDORES_login
            // 
            this.PANEL_CONTENEDORES_login.Location = new System.Drawing.Point(0, 50);
            this.PANEL_CONTENEDORES_login.Name = "PANEL_CONTENEDORES_login";
            this.PANEL_CONTENEDORES_login.Size = new System.Drawing.Size(489, 437);
            this.PANEL_CONTENEDORES_login.TabIndex = 15;            
            // 
            // Window_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 485);
            this.Controls.Add(this.PANEL_CONTENEDORES_login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(55, 55);
            this.Name = "Window_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Window_login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton button_mini;
        private Guna.UI2.WinForms.Guna2ImageButton button_maxi;
        private Guna.UI2.WinForms.Guna2CircleButton button_close;
        private System.Windows.Forms.Panel PANEL_CONTENEDORES_login;
    }
}