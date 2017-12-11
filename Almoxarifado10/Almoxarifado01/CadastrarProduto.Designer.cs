namespace Almoxarifado01
{
    partial class frmCadastrarProduto
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.lblQtdMinima = new System.Windows.Forms.Label();
            this.quantMinima = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(13, 13);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(13, 30);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(251, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(13, 58);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(88, 13);
            this.lblCodBarras.TabIndex = 2;
            this.lblCodBarras.Text = "Código de Barras";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Location = new System.Drawing.Point(13, 74);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(251, 20);
            this.txtCodBarras.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 117);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(251, 63);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 101);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(13, 183);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(13, 200);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(250, 21);
            this.cbFornecedor.TabIndex = 7;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(13, 224);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 8;
            this.lblUnidade.Text = "Unidade";
            // 
            // cbUnidade
            // 
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Location = new System.Drawing.Point(13, 241);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(251, 21);
            this.cbUnidade.TabIndex = 9;
            // 
            // lblQtdMinima
            // 
            this.lblQtdMinima.AutoSize = true;
            this.lblQtdMinima.Location = new System.Drawing.Point(17, 271);
            this.lblQtdMinima.Name = "lblQtdMinima";
            this.lblQtdMinima.Size = new System.Drawing.Size(98, 13);
            this.lblQtdMinima.TabIndex = 10;
            this.lblQtdMinima.Text = "Quantidade Minima";
            // 
            // quantMinima
            // 
            this.quantMinima.Location = new System.Drawing.Point(121, 269);
            this.quantMinima.Name = "quantMinima";
            this.quantMinima.Size = new System.Drawing.Size(120, 20);
            this.quantMinima.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(166, 304);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(40, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 339);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.quantMinima);
            this.Controls.Add(this.lblQtdMinima);
            this.Controls.Add(this.cbUnidade);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.lblCodBarras);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.MaximizeBox = false;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantMinima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.Label lblQtdMinima;
        private System.Windows.Forms.NumericUpDown quantMinima;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}