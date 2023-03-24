namespace Aula14_SistemaLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFormPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFormPrincipal
            // 
            this.lblFormPrincipal.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPrincipal.Location = new System.Drawing.Point(12, 9);
            this.lblFormPrincipal.Name = "lblFormPrincipal";
            this.lblFormPrincipal.Size = new System.Drawing.Size(776, 139);
            this.lblFormPrincipal.TabIndex = 0;
            this.lblFormPrincipal.Text = "Formulário Principal";
            this.lblFormPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormPrincipal.Click += new System.EventHandler(this.lblFormPrincipal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormPrincipal;
    }
}

