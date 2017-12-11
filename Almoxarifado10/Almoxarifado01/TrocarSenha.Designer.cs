namespace Almoxarifado01
{
    partial class frmTrocarSenha
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
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.txtNovaSenha1 = new System.Windows.Forms.TextBox();
            this.lblSenhaNova2 = new System.Windows.Forms.Label();
            this.txtSenhaNova2 = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(12, 9);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(65, 13);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(13, 26);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(259, 20);
            this.txtSenhaAtual.TabIndex = 1;
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.Location = new System.Drawing.Point(12, 49);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(67, 13);
            this.lblSenhaNova.TabIndex = 2;
            this.lblSenhaNova.Text = "Nova Senha";
            // 
            // txtNovaSenha1
            // 
            this.txtNovaSenha1.Location = new System.Drawing.Point(13, 66);
            this.txtNovaSenha1.Name = "txtNovaSenha1";
            this.txtNovaSenha1.PasswordChar = '*';
            this.txtNovaSenha1.Size = new System.Drawing.Size(259, 20);
            this.txtNovaSenha1.TabIndex = 3;
            // 
            // lblSenhaNova2
            // 
            this.lblSenhaNova2.AutoSize = true;
            this.lblSenhaNova2.Location = new System.Drawing.Point(12, 89);
            this.lblSenhaNova2.Name = "lblSenhaNova2";
            this.lblSenhaNova2.Size = new System.Drawing.Size(92, 13);
            this.lblSenhaNova2.TabIndex = 4;
            this.lblSenhaNova2.Text = "Digite Novamente";
            // 
            // txtSenhaNova2
            // 
            this.txtSenhaNova2.Location = new System.Drawing.Point(13, 106);
            this.txtSenhaNova2.Name = "txtSenhaNova2";
            this.txtSenhaNova2.PasswordChar = '*';
            this.txtSenhaNova2.Size = new System.Drawing.Size(259, 20);
            this.txtSenhaNova2.TabIndex = 5;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(154, 145);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(75, 23);
            this.btnTrocar.TabIndex = 6;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(49, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtSenhaNova2);
            this.Controls.Add(this.lblSenhaNova2);
            this.Controls.Add(this.txtNovaSenha1);
            this.Controls.Add(this.lblSenhaNova);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.MaximizeBox = false;
            this.Name = "frmTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.TextBox txtNovaSenha1;
        private System.Windows.Forms.Label lblSenhaNova2;
        private System.Windows.Forms.TextBox txtSenhaNova2;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Button btnCancelar;
    }
}