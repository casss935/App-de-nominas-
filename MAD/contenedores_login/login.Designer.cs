
namespace MAD.contenedores_login
{
    partial class WD_ID_login
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
            this.Login_panel_login = new System.Windows.Forms.Panel();
            this.Login_BTN_login = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_TB_user = new System.Windows.Forms.TextBox();
            this.Login_CB_tipouser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_TB_password = new System.Windows.Forms.TextBox();
            this.Login_Label_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGIN_TB_empresa = new System.Windows.Forms.Label();
            this.Login_panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_panel_login
            // 
            this.Login_panel_login.Controls.Add(this.Login_BTN_login);
            this.Login_panel_login.Controls.Add(this.Login_Label_login);
            this.Login_panel_login.Controls.Add(this.label3);
            this.Login_panel_login.Controls.Add(this.Login_TB_user);
            this.Login_panel_login.Controls.Add(this.Login_CB_tipouser);
            this.Login_panel_login.Controls.Add(this.label2);
            this.Login_panel_login.Controls.Add(this.label4);
            this.Login_panel_login.Controls.Add(this.Login_TB_password);
            this.Login_panel_login.Location = new System.Drawing.Point(80, 161);
            this.Login_panel_login.Name = "Login_panel_login";
            this.Login_panel_login.Size = new System.Drawing.Size(329, 256);
            this.Login_panel_login.TabIndex = 13;
            // 
            // Login_BTN_login
            // 
            this.Login_BTN_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_BTN_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_BTN_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_BTN_login.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN_login.ForeColor = System.Drawing.Color.White;
            this.Login_BTN_login.Location = new System.Drawing.Point(106, 210);
            this.Login_BTN_login.Name = "Login_BTN_login";
            this.Login_BTN_login.Size = new System.Drawing.Size(120, 34);
            this.Login_BTN_login.TabIndex = 9;
            this.Login_BTN_login.Text = "Iniciar sesion";
            this.Login_BTN_login.Click += new System.EventHandler(this.Login_BTN_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // Login_TB_user
            // 
            this.Login_TB_user.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_user.Location = new System.Drawing.Point(141, 108);
            this.Login_TB_user.Name = "Login_TB_user";
            this.Login_TB_user.Size = new System.Drawing.Size(146, 26);
            this.Login_TB_user.TabIndex = 6;
            // 
            // Login_CB_tipouser
            // 
            this.Login_CB_tipouser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_CB_tipouser.FormattingEnabled = true;
            this.Login_CB_tipouser.Items.AddRange(new object[] {
            "Administrador",
            "Colaborador"});
            this.Login_CB_tipouser.Location = new System.Drawing.Point(141, 61);
            this.Login_CB_tipouser.Name = "Login_CB_tipouser";
            this.Login_CB_tipouser.Size = new System.Drawing.Size(146, 27);
            this.Login_CB_tipouser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // Login_TB_password
            // 
            this.Login_TB_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB_password.Location = new System.Drawing.Point(141, 151);
            this.Login_TB_password.Name = "Login_TB_password";
            this.Login_TB_password.Size = new System.Drawing.Size(146, 26);
            this.Login_TB_password.TabIndex = 8;
            // 
            // Login_Label_login
            // 
            this.Login_Label_login.AutoSize = true;
            this.Login_Label_login.BackColor = System.Drawing.Color.Transparent;
            this.Login_Label_login.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.Login_Label_login.Location = new System.Drawing.Point(96, 15);
            this.Login_Label_login.Name = "Login_Label_login";
            this.Login_Label_login.Size = new System.Drawing.Size(128, 26);
            this.Login_Label_login.TabIndex = 14;
            this.Login_Label_login.Text = "Inicia sesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(169, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bienvenido";
            // 
            // LOGIN_TB_empresa
            // 
            this.LOGIN_TB_empresa.AutoSize = true;
            this.LOGIN_TB_empresa.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold);
            this.LOGIN_TB_empresa.Location = new System.Drawing.Point(43, 53);
            this.LOGIN_TB_empresa.Name = "LOGIN_TB_empresa";
            this.LOGIN_TB_empresa.Size = new System.Drawing.Size(71, 26);
            this.LOGIN_TB_empresa.TabIndex = 16;
            this.LOGIN_TB_empresa.Text = "label5";
            // 
            // WD_ID_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LOGIN_TB_empresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_panel_login);
            this.Name = "WD_ID_login";
            this.Size = new System.Drawing.Size(489, 437);
            this.Load += new System.EventHandler(this.WD_ID_login_Load);
            this.Login_panel_login.ResumeLayout(false);
            this.Login_panel_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel_login;
        private Guna.UI2.WinForms.Guna2Button Login_BTN_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_TB_user;
        private System.Windows.Forms.ComboBox Login_CB_tipouser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login_TB_password;
        private System.Windows.Forms.Label Login_Label_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LOGIN_TB_empresa;
    }
}
