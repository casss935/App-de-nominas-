
namespace MAD.contenedores_departamento
{
    partial class CONT_DEP_delete
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DEL_TABLA_dep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DEL_TABLA_dep)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(283, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Seleccione el departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(261, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eliminar departamento ";
            // 
            // DEL_TABLA_dep
            // 
            this.DEL_TABLA_dep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DEL_TABLA_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEL_TABLA_dep.Location = new System.Drawing.Point(200, 115);
            this.DEL_TABLA_dep.Name = "DEL_TABLA_dep";
            this.DEL_TABLA_dep.ReadOnly = true;
            this.DEL_TABLA_dep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DEL_TABLA_dep.Size = new System.Drawing.Size(400, 178);
            this.DEL_TABLA_dep.TabIndex = 21;
            this.DEL_TABLA_dep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DEL_TABLA_dep_CellClick);
            // 
            // CONT_DEP_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DEL_TABLA_dep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CONT_DEP_delete";
            this.Size = new System.Drawing.Size(800, 431);
            this.Load += new System.EventHandler(this.CONT_DEP_delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEL_TABLA_dep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DEL_TABLA_dep;
    }
}
