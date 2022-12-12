
namespace MAD.contenedores_login
{
    partial class WD_ID_empresas
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
            this.EMP_LABEL_title = new System.Windows.Forms.Label();
            this.TABLA_empresas = new System.Windows.Forms.DataGridView();
            this.EMP_PANEL_title = new System.Windows.Forms.Panel();
            this.Login_BTN_login = new Guna.UI2.WinForms.Guna2Button();
            this.Login_Label_login = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.Login_TB_user = new System.Windows.Forms.TextBox();
            this.Login_CB_tipouser = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Login_TB_password = new System.Windows.Forms.TextBox();
            this.EMP_LABEL_empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_empresas)).BeginInit();
            this.EMP_PANEL_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // EMP_LABEL_title
            // 
            this.EMP_LABEL_title.AutoSize = true;
            this.EMP_LABEL_title.BackColor = System.Drawing.Color.Transparent;
            this.EMP_LABEL_title.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.EMP_LABEL_title.Location = new System.Drawing.Point(109, 10);
            this.EMP_LABEL_title.Name = "EMP_LABEL_title";
            this.EMP_LABEL_title.Size = new System.Drawing.Size(284, 31);
            this.EMP_LABEL_title.TabIndex = 15;
            this.EMP_LABEL_title.Text = "Selecciona tu empresa";
            // 
            // TABLA_empresas
            // 
            this.TABLA_empresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLA_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_empresas.Location = new System.Drawing.Point(14, 55);
            this.TABLA_empresas.Name = "TABLA_empresas";
            this.TABLA_empresas.ReadOnly = true;
            this.TABLA_empresas.Size = new System.Drawing.Size(460, 265);
            this.TABLA_empresas.TabIndex = 16;
            this.TABLA_empresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_empresas_CellClick);
            // 
            // EMP_PANEL_title
            // 
            this.EMP_PANEL_title.Controls.Add(this.Login_BTN_login);
            this.EMP_PANEL_title.Controls.Add(this.Login_Label_login);
            this.EMP_PANEL_title.Controls.Add(this.usuario);
            this.EMP_PANEL_title.Controls.Add(this.Login_TB_user);
            this.EMP_PANEL_title.Controls.Add(this.Login_CB_tipouser);
            this.EMP_PANEL_title.Controls.Add(this.Tipo);
            this.EMP_PANEL_title.Controls.Add(this.password);
            this.EMP_PANEL_title.Controls.Add(this.Login_TB_password);
            this.EMP_PANEL_title.Location = new System.Drawing.Point(14, 55);
            this.EMP_PANEL_title.Name = "EMP_PANEL_title";
            this.EMP_PANEL_title.Size = new System.Drawing.Size(460, 265);
            this.EMP_PANEL_title.TabIndex = 17;
            // 
            // Login_BTN_login
            // 
            this.Login_BTN_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_BTN_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_BTN_login.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN_login.ForeColor = System.Drawing.Color.White;
            this.Login_BTN_login.Location = new System.Drawing.Point(168, 217);
            this.Login_BTN_login.Name = "Login_BTN_login";
            this.Login_BTN_login.Size = new System.Drawing.Size(120, 34);
            this.Login_BTN_login.TabIndex = 23;
            this.Login_BTN_login.Text = "Iniciar sesion";
            this.Login_BTN_login.Click += new System.EventHandler(this.Login_BTN_login_Click);
            // 
            // Login_Label_login
            // 
            this.Login_Label_login.AutoSize = true;
            this.Login_Label_login.BackColor = System.Drawing.Color.Transparent;
            this.Login_Label_login.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.Login_Label_login.Location = new System.Drawing.Point(160, 11);
            this.Login_Label_login.Name = "Login_Label_login";
            this.Login_Label_login.Size = new System.Drawing.Size(128, 26);
            this.Login_Label_login.TabIndex = 24;
            this.Login_Label_login.Text = "Inicia sesion";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(116, 117);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(81, 19);
            this.usuario.TabIndex = 19;
            this.usuario.Text = "Usuario:";
            // 
            // Login_TB_user
            // 
            this.Login_TB_user.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_user.Location = new System.Drawing.Point(203, 115);
            this.Login_TB_user.Name = "Login_TB_user";
            this.Login_TB_user.Size = new System.Drawing.Size(146, 26);
            this.Login_TB_user.TabIndex = 20;
            // 
            // Login_CB_tipouser
            // 
            this.Login_CB_tipouser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_CB_tipouser.FormattingEnabled = true;
            this.Login_CB_tipouser.Items.AddRange(new object[] {
            "Administrador",
            "Colaborador"});
            this.Login_CB_tipouser.Location = new System.Drawing.Point(203, 68);
            this.Login_CB_tipouser.Name = "Login_CB_tipouser";
            this.Login_CB_tipouser.Size = new System.Drawing.Size(146, 27);
            this.Login_CB_tipouser.TabIndex = 18;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(143, 71);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(54, 19);
            this.Tipo.TabIndex = 17;
            this.Tipo.Text = "Tipo:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(89, 165);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(108, 19);
            this.password.TabIndex = 21;
            this.password.Text = "Contraseña:";
            // 
            // Login_TB_password
            // 
            this.Login_TB_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_password.Location = new System.Drawing.Point(203, 158);
            this.Login_TB_password.Name = "Login_TB_password";
            this.Login_TB_password.Size = new System.Drawing.Size(146, 26);
            this.Login_TB_password.TabIndex = 22;
            // 
            // EMP_LABEL_empresa
            // 
            this.EMP_LABEL_empresa.AutoSize = true;
            this.EMP_LABEL_empresa.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.EMP_LABEL_empresa.Location = new System.Drawing.Point(75, 10);
            this.EMP_LABEL_empresa.Name = "EMP_LABEL_empresa";
            this.EMP_LABEL_empresa.Size = new System.Drawing.Size(87, 31);
            this.EMP_LABEL_empresa.TabIndex = 0;
            this.EMP_LABEL_empresa.Text = "label1";
            // 
            // WD_ID_empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EMP_PANEL_title);
            this.Controls.Add(this.TABLA_empresas);
            this.Controls.Add(this.EMP_LABEL_title);
            this.Controls.Add(this.EMP_LABEL_empresa);
            this.Name = "WD_ID_empresas";
            this.Size = new System.Drawing.Size(489, 334);
            this.Load += new System.EventHandler(this.WD_ID_empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_empresas)).EndInit();
            this.EMP_PANEL_title.ResumeLayout(false);
            this.EMP_PANEL_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EMP_LABEL_title;
        private System.Windows.Forms.DataGridView TABLA_empresas;
        private System.Windows.Forms.Panel EMP_PANEL_title;
        private System.Windows.Forms.Label EMP_LABEL_empresa;
        private Guna.UI2.WinForms.Guna2Button Login_BTN_login;
        private System.Windows.Forms.Label Login_Label_login;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox Login_TB_user;
        private System.Windows.Forms.ComboBox Login_CB_tipouser;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox Login_TB_password;
    }
}
