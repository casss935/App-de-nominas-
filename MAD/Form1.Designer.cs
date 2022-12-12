
namespace MAD
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_mini = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button_maxi = new Guna.UI2.WinForms.Guna2ImageButton();
            this.button_close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_logout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.id_buttonreportes = new Guna.UI2.WinForms.Guna2Button();
            this.id_buttoncolaboradores = new Guna.UI2.WinForms.Guna2Button();
            this.id_buttonnominas = new Guna.UI2.WinForms.Guna2Button();
            this.id_buttoninicio = new Guna.UI2.WinForms.Guna2Button();
            this.ContenedorHome = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 0;
            // 
            // button_mini
            // 
            this.button_mini.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_mini.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_mini.Image = ((System.Drawing.Image)(resources.GetObject("button_mini.Image")));
            this.button_mini.ImageOffset = new System.Drawing.Point(0, 0);
            this.button_mini.ImageRotate = 0F;
            this.button_mini.ImageSize = new System.Drawing.Size(24, 24);
            this.button_mini.Location = new System.Drawing.Point(718, 9);
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
            this.button_maxi.Location = new System.Drawing.Point(746, 2);
            this.button_maxi.Name = "button_maxi";
            this.button_maxi.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_maxi.Size = new System.Drawing.Size(24, 24);
            this.button_maxi.TabIndex = 1;
            this.button_maxi.Click += new System.EventHandler(this.button_maxi_Click);
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
            this.button_close.Location = new System.Drawing.Point(774, 1);
            this.button_close.Name = "button_close";
            this.button_close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.button_close.Size = new System.Drawing.Size(24, 24);
            this.button_close.TabIndex = 0;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.id_buttonreportes);
            this.panel2.Controls.Add(this.id_buttoncolaboradores);
            this.panel2.Controls.Add(this.id_buttonnominas);
            this.panel2.Controls.Add(this.id_buttoninicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 1;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_logout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button_logout.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.ImageOffset = new System.Drawing.Point(0, 0);
            this.button_logout.ImageRotate = 0F;
            this.button_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Location = new System.Drawing.Point(752, -2);
            this.button_logout.Name = "button_logout";
            this.button_logout.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.button_logout.Size = new System.Drawing.Size(48, 37);
            this.button_logout.TabIndex = 4;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // id_buttonreportes
            // 
            this.id_buttonreportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_buttonreportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.id_buttonreportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.id_buttonreportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.id_buttonreportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.id_buttonreportes.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.id_buttonreportes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.id_buttonreportes.ForeColor = System.Drawing.Color.White;
            this.id_buttonreportes.Location = new System.Drawing.Point(564, -2);
            this.id_buttonreportes.Name = "id_buttonreportes";
            this.id_buttonreportes.Size = new System.Drawing.Size(188, 37);
            this.id_buttonreportes.TabIndex = 3;
            this.id_buttonreportes.Text = "Reportes";
            this.id_buttonreportes.Click += new System.EventHandler(this.id_buttonreportes_Click);
            // 
            // id_buttoncolaboradores
            // 
            this.id_buttoncolaboradores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.id_buttoncolaboradores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.id_buttoncolaboradores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.id_buttoncolaboradores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.id_buttoncolaboradores.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.id_buttoncolaboradores.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buttoncolaboradores.ForeColor = System.Drawing.Color.White;
            this.id_buttoncolaboradores.Location = new System.Drawing.Point(376, -2);
            this.id_buttoncolaboradores.Name = "id_buttoncolaboradores";
            this.id_buttoncolaboradores.Size = new System.Drawing.Size(188, 37);
            this.id_buttoncolaboradores.TabIndex = 2;
            this.id_buttoncolaboradores.Text = "Colaboradores";
            this.id_buttoncolaboradores.Click += new System.EventHandler(this.id_buttoncolaboradores_Click);
            // 
            // id_buttonnominas
            // 
            this.id_buttonnominas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.id_buttonnominas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.id_buttonnominas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.id_buttonnominas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.id_buttonnominas.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.id_buttonnominas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buttonnominas.ForeColor = System.Drawing.Color.White;
            this.id_buttonnominas.Location = new System.Drawing.Point(188, -2);
            this.id_buttonnominas.Name = "id_buttonnominas";
            this.id_buttonnominas.Size = new System.Drawing.Size(188, 37);
            this.id_buttonnominas.TabIndex = 1;
            this.id_buttonnominas.Text = "Nominas";
            this.id_buttonnominas.Click += new System.EventHandler(this.id_buttonnominas_Click);
            // 
            // id_buttoninicio
            // 
            this.id_buttoninicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.id_buttoninicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.id_buttoninicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.id_buttoninicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.id_buttoninicio.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.id_buttoninicio.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_buttoninicio.ForeColor = System.Drawing.Color.White;
            this.id_buttoninicio.Location = new System.Drawing.Point(0, -2);
            this.id_buttoninicio.Name = "id_buttoninicio";
            this.id_buttoninicio.Size = new System.Drawing.Size(188, 37);
            this.id_buttoninicio.TabIndex = 0;
            this.id_buttoninicio.Text = "Inicio ";
            this.id_buttoninicio.Click += new System.EventHandler(this.id_buttoninicio_Click);
            // 
            // ContenedorHome
            // 
            this.ContenedorHome.BackColor = System.Drawing.Color.White;
            this.ContenedorHome.Location = new System.Drawing.Point(0, 84);
            this.ContenedorHome.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorHome.Name = "ContenedorHome";
            this.ContenedorHome.Size = new System.Drawing.Size(800, 517);
            this.ContenedorHome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ContenedorHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(40, 40);
            this.Name = "Form1";
            this.Text = "-+";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ContenedorHome;
        private Guna.UI2.WinForms.Guna2Button id_buttoninicio;
        private Guna.UI2.WinForms.Guna2Button id_buttonreportes;
        private Guna.UI2.WinForms.Guna2Button id_buttoncolaboradores;
        private Guna.UI2.WinForms.Guna2Button id_buttonnominas;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CircleButton button_close;
        private Guna.UI2.WinForms.Guna2ImageButton button_logout;
        private Guna.UI2.WinForms.Guna2ImageButton button_maxi;
        private Guna.UI2.WinForms.Guna2ImageButton button_mini;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}

