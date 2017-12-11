namespace Almoxarifado01
{
    partial class frmProdutoEntrada
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
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblPrateleira = new System.Windows.Forms.Label();
            this.cbPrateleira = new System.Windows.Forms.ComboBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.cbSolicitante = new System.Windows.Forms.ComboBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.maskedtxtValidade = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblRS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(13, 13);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(88, 13);
            this.lblCodBarras.TabIndex = 0;
            this.lblCodBarras.Text = "Código de Barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(13, 30);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(270, 20);
            this.txtCodBarras.TabIndex = 1;
            // 
            // lblPrateleira
            // 
            this.lblPrateleira.AutoSize = true;
            this.lblPrateleira.Location = new System.Drawing.Point(13, 53);
            this.lblPrateleira.Name = "lblPrateleira";
            this.lblPrateleira.Size = new System.Drawing.Size(51, 13);
            this.lblPrateleira.TabIndex = 2;
            this.lblPrateleira.Text = "Prateleira";
            // 
            // cbPrateleira
            // 
            this.cbPrateleira.FormattingEnabled = true;
            this.cbPrateleira.Location = new System.Drawing.Point(13, 70);
            this.cbPrateleira.Name = "cbPrateleira";
            this.cbPrateleira.Size = new System.Drawing.Size(270, 21);
            this.cbPrateleira.TabIndex = 3;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(13, 94);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(56, 13);
            this.lblSolicitante.TabIndex = 4;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // cbSolicitante
            // 
            this.cbSolicitante.FormattingEnabled = true;
            this.cbSolicitante.Location = new System.Drawing.Point(13, 111);
            this.cbSolicitante.Name = "cbSolicitante";
            this.cbSolicitante.Size = new System.Drawing.Size(270, 21);
            this.cbSolicitante.TabIndex = 5;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(13, 135);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 6;
            this.lblValidade.Text = "Validade";
            // 
            // maskedtxtValidade
            // 
            this.maskedtxtValidade.Location = new System.Drawing.Point(13, 152);
            this.maskedtxtValidade.Mask = "00/0000";
            this.maskedtxtValidade.Name = "maskedtxtValidade";
            this.maskedtxtValidade.Size = new System.Drawing.Size(56, 20);
            this.maskedtxtValidade.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(84, 135);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // numericQuant
            // 
            this.numericQuant.Location = new System.Drawing.Point(87, 151);
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(74, 20);
            this.numericQuant.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(180, 135);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(173, 188);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(56, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(206, 151);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(77, 20);
            this.txtPreco.TabIndex = 10;
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(180, 154);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(21, 13);
            this.lblRS.TabIndex = 14;
            this.lblRS.Text = "R$";
            // 
            // frmProdutoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 223);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.numericQuant);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.maskedtxtValidade);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.cbSolicitante);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.cbPrateleira);
            this.Controls.Add(this.lblPrateleira);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.lblCodBarras);
            this.MaximizeBox = false;
            this.Name = "frmProdutoEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produto";
            this.Load += new System.EventHandler(this.frmProdutoEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lblPrateleira;
        private System.Windows.Forms.ComboBox cbPrateleira;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.ComboBox cbSolicitante;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.MaskedTextBox maskedtxtValidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown numericQuant;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblRS;
    }
}