﻿namespace Almoxarifado01
{
    partial class frmSolicitanteAdicionar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(13, 52);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(32, 13);
            this.lblSetor.TabIndex = 2;
            this.lblSetor.Text = "Setor";
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(12, 69);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(260, 21);
            this.cbSetor.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(154, 107);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(49, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSolicitanteAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.Name = "frmSolicitanteAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Solicitante";
            this.Load += new System.EventHandler(this.frmSolicitanteAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
    }
}