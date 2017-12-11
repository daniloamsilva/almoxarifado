namespace Almoxarifado01
{
    partial class frmSobre
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
            this.lblDanilo = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDanilo
            // 
            this.lblDanilo.AutoSize = true;
            this.lblDanilo.Location = new System.Drawing.Point(12, 9);
            this.lblDanilo.Name = "lblDanilo";
            this.lblDanilo.Size = new System.Drawing.Size(206, 13);
            this.lblDanilo.TabIndex = 0;
            this.lblDanilo.Text = "Desenvolvido por Danilo Augusto M. Silva";
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(12, 31);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(335, 13);
            this.lblSistema.TabIndex = 1;
            this.lblSistema.Text = "Sistema desenvolvido para o Almoxarifado da Faculdade Anhanguera";
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Location = new System.Drawing.Point(12, 53);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(175, 13);
            this.lblDireitos.TabIndex = 2;
            this.lblDireitos.Text = "Todos os Direitos Reservados (sqn)";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 79);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.lblDanilo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanilo;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblDireitos;
    }
}