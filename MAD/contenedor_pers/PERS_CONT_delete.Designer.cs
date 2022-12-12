
namespace MAD.contenedor_deducciones
{
    partial class PERS_CONT_delete
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
            this.Ded_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ded_title
            // 
            this.Ded_title.AutoSize = true;
            this.Ded_title.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ded_title.Location = new System.Drawing.Point(277, 22);
            this.Ded_title.Name = "Ded_title";
            this.Ded_title.Size = new System.Drawing.Size(235, 28);
            this.Ded_title.TabIndex = 7;
            this.Ded_title.Text = "Eliminar percepciones";
            // 
            // PERS_CONT_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ded_title);
            this.Name = "PERS_CONT_delete";
            this.Size = new System.Drawing.Size(800, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ded_title;
    }
}
