namespace Proyecto
{
    partial class Autenticacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnICancelar = new System.Windows.Forms.Button();
            this.txtIUsuario = new System.Windows.Forms.TextBox();
            this.txtIContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(52, 148);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 35);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnICancelar
            // 
            this.btnICancelar.Location = new System.Drawing.Point(208, 148);
            this.btnICancelar.Name = "btnICancelar";
            this.btnICancelar.Size = new System.Drawing.Size(100, 35);
            this.btnICancelar.TabIndex = 4;
            this.btnICancelar.Text = "Cancelar";
            this.btnICancelar.UseVisualStyleBackColor = true;
            this.btnICancelar.Click += new System.EventHandler(this.btnICancelar_Click);
            // 
            // txtIUsuario
            // 
            this.txtIUsuario.Location = new System.Drawing.Point(141, 64);
            this.txtIUsuario.Name = "txtIUsuario";
            this.txtIUsuario.Size = new System.Drawing.Size(229, 22);
            this.txtIUsuario.TabIndex = 5;
            // 
            // txtIContraseña
            // 
            this.txtIContraseña.Location = new System.Drawing.Point(139, 108);
            this.txtIContraseña.Name = "txtIContraseña";
            this.txtIContraseña.PasswordChar = '*';
            this.txtIContraseña.Size = new System.Drawing.Size(229, 22);
            this.txtIContraseña.TabIndex = 6;
            // 
            // Autenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 209);
            this.Controls.Add(this.txtIContraseña);
            this.Controls.Add(this.txtIUsuario);
            this.Controls.Add(this.btnICancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autenticacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnICancelar;
        private System.Windows.Forms.TextBox txtIUsuario;
        private System.Windows.Forms.TextBox txtIContraseña;
    }
}