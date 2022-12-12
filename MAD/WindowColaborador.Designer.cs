
namespace MAD
{
    partial class WindowColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowColaborador));
            this.WC_Panel_header = new System.Windows.Forms.Panel();
            this.WC_button_mini = new Guna.UI2.WinForms.Guna2ImageButton();
            this.WC_button_maxi = new Guna.UI2.WinForms.Guna2ImageButton();
            this.WC_button_close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_logout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.WC_id_buttoncolaboradores = new Guna.UI2.WinForms.Guna2Button();
            this.WC_id_buttonnominas = new Guna.UI2.WinForms.Guna2Button();
            this.WC_id_buttoninicio = new Guna.UI2.WinForms.Guna2Button();
            this.WC_Panel_contenedor = new System.Windows.Forms.Panel();
            this.WC_Panel_header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WC_Panel_header
            // 
            this.WC_Panel_header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WC_Panel_header.Controls.Add(this.WC_button_mini);
            this.WC_Panel_header.Controls.Add(this.WC_button_maxi);
            this.WC_Panel_header.Controls.Add(this.WC_button_close);
            this.WC_Panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.WC_Panel_header.Location = new System.Drawing.Point(0, 0);
            this.WC_Panel_header.Name = "WC_Panel_header";
            this.WC_Panel_header.Size = new System.Drawing.Size(800, 50);
            this.WC_Panel_header.TabIndex = 1;
            // 
            // WC_button_mini
            // 
            this.WC_button_mini.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_mini.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_mini.Image = ((System.Drawing.Image)(resources.GetObject("WC_button_mini.Image")));
            this.WC_button_mini.ImageOffset = new System.Drawing.Point(0, 0);
            this.WC_button_mini.ImageRotate = 0F;
            this.WC_button_mini.ImageSize = new System.Drawing.Size(24, 24);
            this.WC_button_mini.Location = new System.Drawing.Point(718, 9);
            this.WC_button_mini.Name = "WC_button_mini";
            this.WC_button_mini.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_mini.Size = new System.Drawing.Size(24, 24);
            this.WC_button_mini.TabIndex = 2;
            // 
            // WC_button_maxi
            // 
            this.WC_button_maxi.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_maxi.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_maxi.Image = ((System.Drawing.Image)(resources.GetObject("WC_button_maxi.Image")));
            this.WC_button_maxi.ImageOffset = new System.Drawing.Point(0, 0);
            this.WC_button_maxi.ImageRotate = 0F;
            this.WC_button_maxi.ImageSize = new System.Drawing.Size(24, 24);
            this.WC_button_maxi.Location = new System.Drawing.Point(746, 2);
            this.WC_button_maxi.Name = "WC_button_maxi";
            this.WC_button_maxi.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.WC_button_maxi.Size = new System.Drawing.Size(24, 24);
            this.WC_button_maxi.TabIndex = 1;
            // 
            // WC_button_close
            // 
            this.WC_button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WC_button_close.BackgroundImage")));
            this.WC_button_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WC_button_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WC_button_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WC_button_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WC_button_close.FillColor = System.Drawing.Color.Transparent;
            this.WC_button_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WC_button_close.ForeColor = System.Drawing.Color.White;
            this.WC_button_close.Location = new System.Drawing.Point(774, 1);
            this.WC_button_close.Name = "WC_button_close";
            this.WC_button_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.WC_button_close.Size = new System.Drawing.Size(24, 24);
            this.WC_button_close.TabIndex = 0;
            this.WC_button_close.Click += new System.EventHandler(this.WC_button_close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.WC_id_buttoncolaboradores);
            this.panel2.Controls.Add(this.WC_id_buttonnominas);
            this.panel2.Controls.Add(this.WC_id_buttoninicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 2;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button_logout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_logout.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.ImageOffset = new System.Drawing.Point(0, 0);
            this.button_logout.ImageRotate = 0F;
            this.button_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Location = new System.Drawing.Point(750, 0);
            this.button_logout.Name = "button_logout";
            this.button_logout.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Size = new System.Drawing.Size(50, 38);
            this.button_logout.TabIndex = 4;
            // 
            // WC_id_buttoncolaboradores
            // 
            this.WC_id_buttoncolaboradores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttoncolaboradores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttoncolaboradores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WC_id_buttoncolaboradores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WC_id_buttoncolaboradores.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC_id_buttoncolaboradores.ForeColor = System.Drawing.Color.White;
            this.WC_id_buttoncolaboradores.Location = new System.Drawing.Point(500, 0);
            this.WC_id_buttoncolaboradores.Name = "WC_id_buttoncolaboradores";
            this.WC_id_buttoncolaboradores.Size = new System.Drawing.Size(250, 38);
            this.WC_id_buttoncolaboradores.TabIndex = 2;
            this.WC_id_buttoncolaboradores.Text = "Datos personales";
            this.WC_id_buttoncolaboradores.Click += new System.EventHandler(this.WC_id_buttoncolaboradores_Click);
            // 
            // WC_id_buttonnominas
            // 
            this.WC_id_buttonnominas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttonnominas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttonnominas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WC_id_buttonnominas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WC_id_buttonnominas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC_id_buttonnominas.ForeColor = System.Drawing.Color.White;
            this.WC_id_buttonnominas.Location = new System.Drawing.Point(250, 0);
            this.WC_id_buttonnominas.Name = "WC_id_buttonnominas";
            this.WC_id_buttonnominas.Size = new System.Drawing.Size(250, 38);
            this.WC_id_buttonnominas.TabIndex = 1;
            this.WC_id_buttonnominas.Text = "Nominas";
            this.WC_id_buttonnominas.Click += new System.EventHandler(this.WC_id_buttonnominas_Click);
            // 
            // WC_id_buttoninicio
            // 
            this.WC_id_buttoninicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttoninicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WC_id_buttoninicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WC_id_buttoninicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WC_id_buttoninicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.WC_id_buttoninicio.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC_id_buttoninicio.ForeColor = System.Drawing.Color.White;
            this.WC_id_buttoninicio.Location = new System.Drawing.Point(0, 0);
            this.WC_id_buttoninicio.Name = "WC_id_buttoninicio";
            this.WC_id_buttoninicio.Size = new System.Drawing.Size(250, 38);
            this.WC_id_buttoninicio.TabIndex = 0;
            this.WC_id_buttoninicio.Text = "Inicio ";
            this.WC_id_buttoninicio.Click += new System.EventHandler(this.WC_id_buttoninicio_Click);
            // 
            // WC_Panel_contenedor
            // 
            this.WC_Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WC_Panel_contenedor.Location = new System.Drawing.Point(0, 88);
            this.WC_Panel_contenedor.Name = "WC_Panel_contenedor";
            this.WC_Panel_contenedor.Size = new System.Drawing.Size(800, 512);
            this.WC_Panel_contenedor.TabIndex = 3;
            // 
            // WindowColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.WC_Panel_contenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WC_Panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "WindowColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WindowColaborador";
            this.WC_Panel_header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WC_Panel_header;
        private Guna.UI2.WinForms.Guna2ImageButton WC_button_mini;
        private Guna.UI2.WinForms.Guna2ImageButton WC_button_maxi;
        private Guna.UI2.WinForms.Guna2CircleButton WC_button_close;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton button_logout;
        private Guna.UI2.WinForms.Guna2Button WC_id_buttoncolaboradores;
        private Guna.UI2.WinForms.Guna2Button WC_id_buttonnominas;
        private Guna.UI2.WinForms.Guna2Button WC_id_buttoninicio;
        private System.Windows.Forms.Panel WC_Panel_contenedor;
    }
}