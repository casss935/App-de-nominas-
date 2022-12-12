
namespace MAD.contenedores
{
    partial class ID_inicio
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
            this.Home_panel_home = new System.Windows.Forms.Panel();
            this.HOME_BTN_home = new Guna.UI2.WinForms.Guna2Button();
            this.HOME_BTN_adddepartamento = new Guna.UI2.WinForms.Guna2Button();
            this.HOME_BTN_addpuesto = new Guna.UI2.WinForms.Guna2Button();
            this.HOME_panel_contenedores = new System.Windows.Forms.Panel();
            this.Home_panel_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home_panel_home
            // 
            this.Home_panel_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Home_panel_home.Controls.Add(this.HOME_BTN_addpuesto);
            this.Home_panel_home.Controls.Add(this.HOME_BTN_adddepartamento);
            this.Home_panel_home.Controls.Add(this.HOME_BTN_home);
            this.Home_panel_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_panel_home.Location = new System.Drawing.Point(0, 0);
            this.Home_panel_home.Name = "Home_panel_home";
            this.Home_panel_home.Size = new System.Drawing.Size(800, 44);
            this.Home_panel_home.TabIndex = 0;
            // 
            // HOME_BTN_home
            // 
            this.HOME_BTN_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HOME_BTN_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HOME_BTN_home.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.HOME_BTN_home.ForeColor = System.Drawing.Color.White;
            this.HOME_BTN_home.Location = new System.Drawing.Point(0, 0);
            this.HOME_BTN_home.Name = "HOME_BTN_home";
            this.HOME_BTN_home.Size = new System.Drawing.Size(200, 44);
            this.HOME_BTN_home.TabIndex = 0;
            this.HOME_BTN_home.Text = "Inicio";
            this.HOME_BTN_home.Click += new System.EventHandler(this.HOME_BTN_home_Click);
            // 
            // HOME_BTN_adddepartamento
            // 
            this.HOME_BTN_adddepartamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_adddepartamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_adddepartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HOME_BTN_adddepartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HOME_BTN_adddepartamento.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.HOME_BTN_adddepartamento.ForeColor = System.Drawing.Color.White;
            this.HOME_BTN_adddepartamento.Location = new System.Drawing.Point(200, 0);
            this.HOME_BTN_adddepartamento.Name = "HOME_BTN_adddepartamento";
            this.HOME_BTN_adddepartamento.Size = new System.Drawing.Size(300, 44);
            this.HOME_BTN_adddepartamento.TabIndex = 1;
            this.HOME_BTN_adddepartamento.Text = "Agregar departamentos";
            this.HOME_BTN_adddepartamento.Click += new System.EventHandler(this.HOME_BTN_adddepartamento_Click);
            // 
            // HOME_BTN_addpuesto
            // 
            this.HOME_BTN_addpuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_addpuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HOME_BTN_addpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HOME_BTN_addpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HOME_BTN_addpuesto.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.HOME_BTN_addpuesto.ForeColor = System.Drawing.Color.White;
            this.HOME_BTN_addpuesto.Location = new System.Drawing.Point(500, 0);
            this.HOME_BTN_addpuesto.Name = "HOME_BTN_addpuesto";
            this.HOME_BTN_addpuesto.Size = new System.Drawing.Size(300, 44);
            this.HOME_BTN_addpuesto.TabIndex = 2;
            this.HOME_BTN_addpuesto.Text = "Agregar puestos";
            this.HOME_BTN_addpuesto.Click += new System.EventHandler(this.HOME_BTN_addpuesto_Click);
            // 
            // HOME_panel_contenedores
            // 
            this.HOME_panel_contenedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HOME_panel_contenedores.Location = new System.Drawing.Point(0, 44);
            this.HOME_panel_contenedores.Name = "HOME_panel_contenedores";
            this.HOME_panel_contenedores.Size = new System.Drawing.Size(800, 468);
            this.HOME_panel_contenedores.TabIndex = 1;
            // 
            // ID_inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.HOME_panel_contenedores);
            this.Controls.Add(this.Home_panel_home);
            this.Name = "ID_inicio";
            this.Size = new System.Drawing.Size(800, 512);
            this.Home_panel_home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home_panel_home;
        private Guna.UI2.WinForms.Guna2Button HOME_BTN_addpuesto;
        private Guna.UI2.WinForms.Guna2Button HOME_BTN_adddepartamento;
        private Guna.UI2.WinForms.Guna2Button HOME_BTN_home;
        private System.Windows.Forms.Panel HOME_panel_contenedores;
    }
}
