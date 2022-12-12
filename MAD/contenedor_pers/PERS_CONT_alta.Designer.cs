
namespace MAD.contenedor_deducciones
{
    partial class PERS_CONT_alta
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
            this.panel_home_addpercepcion = new System.Windows.Forms.Panel();
            this.PERS_BTN_guardar = new System.Windows.Forms.Button();
            this.PERS_CB_tipo = new System.Windows.Forms.ComboBox();
            this.PERS_CCKB_no = new System.Windows.Forms.CheckBox();
            this.PERS_CCKB_si = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PERS_TB_nombre = new System.Windows.Forms.TextBox();
            this.PERS_TB_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ded_title = new System.Windows.Forms.Label();
            this.panel_home_addpercepcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_home_addpercepcion
            // 
            this.panel_home_addpercepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel_home_addpercepcion.Controls.Add(this.PERS_BTN_guardar);
            this.panel_home_addpercepcion.Controls.Add(this.PERS_CB_tipo);
            this.panel_home_addpercepcion.Controls.Add(this.PERS_CCKB_no);
            this.panel_home_addpercepcion.Controls.Add(this.PERS_CCKB_si);
            this.panel_home_addpercepcion.Controls.Add(this.label4);
            this.panel_home_addpercepcion.Controls.Add(this.PERS_TB_nombre);
            this.panel_home_addpercepcion.Controls.Add(this.PERS_TB_cantidad);
            this.panel_home_addpercepcion.Controls.Add(this.label1);
            this.panel_home_addpercepcion.Controls.Add(this.label2);
            this.panel_home_addpercepcion.Location = new System.Drawing.Point(152, 98);
            this.panel_home_addpercepcion.Name = "panel_home_addpercepcion";
            this.panel_home_addpercepcion.Size = new System.Drawing.Size(500, 259);
            this.panel_home_addpercepcion.TabIndex = 7;
            // 
            // PERS_BTN_guardar
            // 
            this.PERS_BTN_guardar.BackColor = System.Drawing.Color.White;
            this.PERS_BTN_guardar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PERS_BTN_guardar.Location = new System.Drawing.Point(209, 203);
            this.PERS_BTN_guardar.Name = "PERS_BTN_guardar";
            this.PERS_BTN_guardar.Size = new System.Drawing.Size(87, 34);
            this.PERS_BTN_guardar.TabIndex = 9;
            this.PERS_BTN_guardar.Text = "Guardar";
            this.PERS_BTN_guardar.UseVisualStyleBackColor = false;
            this.PERS_BTN_guardar.Click += new System.EventHandler(this.PERS_BTN_guardar_Click);
            // 
            // PERS_CB_tipo
            // 
            this.PERS_CB_tipo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.PERS_CB_tipo.FormattingEnabled = true;
            this.PERS_CB_tipo.Items.AddRange(new object[] {
            "Porcetaje ",
            "Monto"});
            this.PERS_CB_tipo.Location = new System.Drawing.Point(316, 92);
            this.PERS_CB_tipo.Name = "PERS_CB_tipo";
            this.PERS_CB_tipo.Size = new System.Drawing.Size(121, 25);
            this.PERS_CB_tipo.TabIndex = 8;
            // 
            // PERS_CCKB_no
            // 
            this.PERS_CCKB_no.AutoSize = true;
            this.PERS_CCKB_no.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PERS_CCKB_no.ForeColor = System.Drawing.Color.White;
            this.PERS_CCKB_no.Location = new System.Drawing.Point(355, 138);
            this.PERS_CCKB_no.Name = "PERS_CCKB_no";
            this.PERS_CCKB_no.Size = new System.Drawing.Size(52, 25);
            this.PERS_CCKB_no.TabIndex = 7;
            this.PERS_CCKB_no.Text = "No";
            this.PERS_CCKB_no.UseVisualStyleBackColor = true;
            // 
            // PERS_CCKB_si
            // 
            this.PERS_CCKB_si.AutoSize = true;
            this.PERS_CCKB_si.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.PERS_CCKB_si.ForeColor = System.Drawing.Color.White;
            this.PERS_CCKB_si.Location = new System.Drawing.Point(307, 138);
            this.PERS_CCKB_si.Name = "PERS_CCKB_si";
            this.PERS_CCKB_si.Size = new System.Drawing.Size(42, 25);
            this.PERS_CCKB_si.TabIndex = 6;
            this.PERS_CCKB_si.Text = "Si";
            this.PERS_CCKB_si.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(101, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "¿Esta percepcion es  fija?";
            // 
            // PERS_TB_nombre
            // 
            this.PERS_TB_nombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERS_TB_nombre.Location = new System.Drawing.Point(156, 52);
            this.PERS_TB_nombre.Name = "PERS_TB_nombre";
            this.PERS_TB_nombre.Size = new System.Drawing.Size(281, 25);
            this.PERS_TB_nombre.TabIndex = 3;
            // 
            // PERS_TB_cantidad
            // 
            this.PERS_TB_cantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERS_TB_cantidad.Location = new System.Drawing.Point(156, 92);
            this.PERS_TB_cantidad.Name = "PERS_TB_cantidad";
            this.PERS_TB_cantidad.Size = new System.Drawing.Size(154, 25);
            this.PERS_TB_cantidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // Ded_title
            // 
            this.Ded_title.AutoSize = true;
            this.Ded_title.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ded_title.Location = new System.Drawing.Point(285, 35);
            this.Ded_title.Name = "Ded_title";
            this.Ded_title.Size = new System.Drawing.Size(233, 28);
            this.Ded_title.TabIndex = 6;
            this.Ded_title.Text = "Agregar percepciones";
            // 
            // PERS_CONT_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_home_addpercepcion);
            this.Controls.Add(this.Ded_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "PERS_CONT_alta";
            this.Size = new System.Drawing.Size(800, 449);
            this.panel_home_addpercepcion.ResumeLayout(false);
            this.panel_home_addpercepcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_home_addpercepcion;
        private System.Windows.Forms.TextBox PERS_TB_nombre;
        private System.Windows.Forms.TextBox PERS_TB_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ded_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PERS_CB_tipo;
        private System.Windows.Forms.Button PERS_BTN_guardar;
        private System.Windows.Forms.CheckBox PERS_CCKB_no;
        private System.Windows.Forms.CheckBox PERS_CCKB_si;
    }
}
