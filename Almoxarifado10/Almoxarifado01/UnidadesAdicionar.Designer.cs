namespace Almoxarifado01
{
    partial class frmUnidadeAdicionar
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
            this.lblNomeUnidade = new System.Windows.Forms.Label();
            this.txtNomeUnidade = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblInfoDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeUnidade
            // 
            this.lblNomeUnidade.AutoSize = true;
            this.lblNomeUnidade.Location = new System.Drawing.Point(13, 13);
            this.lblNomeUnidade.Name = "lblNomeUnidade";
            this.lblNomeUnidade.Size = new System.Drawing.Size(93, 13);
            this.lblNomeUnidade.TabIndex = 0;
            this.lblNomeUnidade.Text = "Nome da Unidade";
            // 
            // txtNomeUnidade
            // 
            this.txtNomeUnidade.Location = new System.Drawing.Point(16, 30);
            this.txtNomeUnidade.Name = "txtNomeUnidade";
            this.txtNomeUnidade.Size = new System.Drawing.Size(254, 20);
            this.txtNomeUnidade.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 53);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 70);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(254, 44);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(48, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(159, 148);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblInfoDescricao
            // 
            this.lblInfoDescricao.AutoSize = true;
            this.lblInfoDescricao.Location = new System.Drawing.Point(23, 117);
            this.lblInfoDescricao.Name = "lblInfoDescricao";
            this.lblInfoDescricao.Size = new System.Drawing.Size(237, 13);
            this.lblInfoDescricao.TabIndex = 4;
            this.lblInfoDescricao.Text = "*A descrição deve conter no máximo 100 digitos.";
            // 
            // frmUnidadeAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.lblInfoDescricao);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeUnidade);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeUnidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUnidadeAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Unidade";
            this.Load += new System.EventHandler(this.frmUnidadeAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeUnidade;
        private System.Windows.Forms.TextBox txtNomeUnidade;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblInfoDescricao;
    }
}