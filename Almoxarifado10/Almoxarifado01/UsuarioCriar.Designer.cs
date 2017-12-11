namespace Almoxarifado01
{
    partial class frmUsuarioAdicionar
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
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.maskedtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblPrivilegio = new System.Windows.Forms.Label();
            this.cbPrivilegio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(9, 9);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome do Usuário";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(12, 25);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(250, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Location = new System.Drawing.Point(9, 48);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(38, 13);
            this.lblSenha1.TabIndex = 2;
            this.lblSenha1.Text = "Senha";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(12, 64);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.PasswordChar = '*';
            this.txtSenha1.Size = new System.Drawing.Size(250, 20);
            this.txtSenha1.TabIndex = 3;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(9, 87);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(96, 13);
            this.lblSenha2.TabIndex = 4;
            this.lblSenha2.Text = "Senha Novamente";
            this.lblSenha2.Click += new System.EventHandler(this.lblSenha2_Click);
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(12, 103);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(250, 20);
            this.txtSenha2.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 126);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF";
            // 
            // maskedtxtCpf
            // 
            this.maskedtxtCpf.Location = new System.Drawing.Point(12, 142);
            this.maskedtxtCpf.Mask = "000,000,000-00";
            this.maskedtxtCpf.Name = "maskedtxtCpf";
            this.maskedtxtCpf.Size = new System.Drawing.Size(93, 20);
            this.maskedtxtCpf.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(174, 225);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnCriarUsuario_Click);
            // 
            // lblPrivilegio
            // 
            this.lblPrivilegio.AutoSize = true;
            this.lblPrivilegio.Location = new System.Drawing.Point(119, 126);
            this.lblPrivilegio.Name = "lblPrivilegio";
            this.lblPrivilegio.Size = new System.Drawing.Size(49, 13);
            this.lblPrivilegio.TabIndex = 12;
            this.lblPrivilegio.Text = "Privilegio";
            // 
            // cbPrivilegio
            // 
            this.cbPrivilegio.FormattingEnabled = true;
            this.cbPrivilegio.Items.AddRange(new object[] {
            "TOTAL",
            "ALTO",
            "BAIXO"});
            this.cbPrivilegio.Location = new System.Drawing.Point(122, 140);
            this.cbPrivilegio.Name = "cbPrivilegio";
            this.cbPrivilegio.Size = new System.Drawing.Size(140, 21);
            this.cbPrivilegio.TabIndex = 8;
            // 
            // frmUsuarioAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.cbPrivilegio);
            this.Controls.Add(this.lblPrivilegio);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.maskedtxtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.lblSenha1);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.frmUsuarioAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox maskedtxtCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblPrivilegio;
        private System.Windows.Forms.ComboBox cbPrivilegio;
    }
}