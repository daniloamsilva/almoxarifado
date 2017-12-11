namespace Almoxarifado01
{
    partial class frmUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnidades));
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dgvUnidade = new System.Windows.Forms.DataGridView();
            this.tstBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tstBotoes
            // 
            this.tstBotoes.AutoSize = false;
            this.tstBotoes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tstBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tstBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnExcluir,
            this.btnAtualizar,
            this.btnSair});
            this.tstBotoes.Location = new System.Drawing.Point(0, 0);
            this.tstBotoes.Name = "tstBotoes";
            this.tstBotoes.Size = new System.Drawing.Size(55, 281);
            this.tstBotoes.TabIndex = 0;
            this.tstBotoes.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = false;
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(50, 50);
            this.btnAdicionar.Text = "Adicionar Unidade";
            this.btnAdicionar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(50, 50);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = false;
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(50, 50);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = false;
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgvUnidade
            // 
            this.dgvUnidade.AllowUserToAddRows = false;
            this.dgvUnidade.AllowUserToDeleteRows = false;
            this.dgvUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidade.Location = new System.Drawing.Point(58, 12);
            this.dgvUnidade.Name = "dgvUnidade";
            this.dgvUnidade.ReadOnly = true;
            this.dgvUnidade.Size = new System.Drawing.Size(647, 257);
            this.dgvUnidade.TabIndex = 1;
            // 
            // frmUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 281);
            this.Controls.Add(this.dgvUnidade);
            this.Controls.Add(this.tstBotoes);
            this.Name = "frmUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.frmUnidades_Load);
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstBotoes;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.DataGridView dgvUnidade;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnExcluir;
    }
}