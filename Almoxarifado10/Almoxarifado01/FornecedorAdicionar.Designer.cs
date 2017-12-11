namespace Almoxarifado01
{
    partial class frmFornecedorAdicionar
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
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.maskedCnpj = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(9, 9);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(107, 13);
            this.lblNomeFornecedor.TabIndex = 0;
            this.lblNomeFornecedor.Text = "Nome do Fornecedor";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(12, 25);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(256, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(9, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 0;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(9, 87);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(12, 103);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(256, 20);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(9, 126);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 142);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(181, 20);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(199, 126);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(202, 142);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(9, 165);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 181);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(256, 20);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(9, 204);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(44, 13);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "Contato";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(12, 220);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(131, 20);
            this.txtContato.TabIndex = 7;
            this.txtContato.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(149, 204);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(41, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(152, 258);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // maskedCnpj
            // 
            this.maskedCnpj.Location = new System.Drawing.Point(13, 65);
            this.maskedCnpj.Mask = "00,000,000/0000-00";
            this.maskedCnpj.Name = "maskedCnpj";
            this.maskedCnpj.Size = new System.Drawing.Size(255, 20);
            this.maskedCnpj.TabIndex = 2;
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.Location = new System.Drawing.Point(152, 220);
            this.maskedTelefone.Mask = "(00) 0000-0000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(116, 20);
            this.maskedTelefone.TabIndex = 8;
            // 
            // frmFornecedorAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.maskedTelefone);
            this.Controls.Add(this.maskedCnpj);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblNomeFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedorAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox maskedCnpj;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
    }
}