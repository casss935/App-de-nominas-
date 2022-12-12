
namespace MAD.contenedores_puesto
{
    partial class PST_CONT_del
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
            this.TABLA_puestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(313, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Seleccione el puesto";
            // 
            // TABLA_puestos
            // 
            this.TABLA_puestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLA_puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA_puestos.Location = new System.Drawing.Point(163, 119);
            this.TABLA_puestos.Name = "TABLA_puestos";
            this.TABLA_puestos.ReadOnly = true;
            this.TABLA_puestos.Size = new System.Drawing.Size(474, 283);
            this.TABLA_puestos.TabIndex = 22;
            this.TABLA_puestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TABLA_puestos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Eliminar puesto";
            // 
            // PST_CONT_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TABLA_puestos);
            this.Controls.Add(this.label1);
            this.Name = "PST_CONT_del";
            this.Size = new System.Drawing.Size(800, 431);
            this.Load += new System.EventHandler(this.PST_CONT_del_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA_puestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TABLA_puestos;
        private System.Windows.Forms.Label label1;
    }
}
