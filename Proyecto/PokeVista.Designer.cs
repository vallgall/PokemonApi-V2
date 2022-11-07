namespace Proyecto
{
    partial class PokeVista
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
            this.imagen = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(13, 15);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(119, 82);
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(48, 112);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 16);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "label1";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // PokeVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.imagen);
            this.Name = "PokeVista";
            this.Size = new System.Drawing.Size(148, 151);
            this.Load += new System.EventHandler(this.PokeVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label nombre;
    }
}
