namespace NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N
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
            this.btn_proceso = new System.Windows.Forms.Button();
            this.btn_env_com = new System.Windows.Forms.Button();
            this.txt_comando = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_proceso
            // 
            this.btn_proceso.Location = new System.Drawing.Point(12, 12);
            this.btn_proceso.Name = "btn_proceso";
            this.btn_proceso.Size = new System.Drawing.Size(75, 23);
            this.btn_proceso.TabIndex = 0;
            this.btn_proceso.Text = "proceso";
            this.btn_proceso.UseVisualStyleBackColor = true;
            this.btn_proceso.Click += new System.EventHandler(this.btn_proceso_Click);
            // 
            // btn_env_com
            // 
            this.btn_env_com.Location = new System.Drawing.Point(67, 145);
            this.btn_env_com.Name = "btn_env_com";
            this.btn_env_com.Size = new System.Drawing.Size(75, 46);
            this.btn_env_com.TabIndex = 1;
            this.btn_env_com.Text = "enviar comando";
            this.btn_env_com.UseVisualStyleBackColor = true;
            this.btn_env_com.Click += new System.EventHandler(this.btn_env_com_Click);
            // 
            // txt_comando
            // 
            this.txt_comando.Location = new System.Drawing.Point(67, 119);
            this.txt_comando.Name = "txt_comando";
            this.txt_comando.Size = new System.Drawing.Size(100, 20);
            this.txt_comando.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_comando);
            this.Controls.Add(this.btn_env_com);
            this.Controls.Add(this.btn_proceso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_proceso;
        private System.Windows.Forms.Button btn_env_com;
        private System.Windows.Forms.TextBox txt_comando;
    }
}

