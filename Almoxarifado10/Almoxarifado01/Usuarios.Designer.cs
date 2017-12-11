namespace Almoxarifado01
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.btnInserirUsuario = new System.Windows.Forms.ToolStripButton();
            this.tstBotoes = new System.Windows.Forms.ToolStrip();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tstBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserirUsuario
            // 
            this.btnInserirUsuario.AutoSize = false;
            this.btnInserirUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserirUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirUsuario.Image")));
            this.btnInserirUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserirUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserirUsuario.Name = "btnInserirUsuario";
            this.btnInserirUsuario.Size = new System.Drawing.Size(50, 50);
            this.btnInserirUsuario.Text = "Adicionar";
            this.btnInserirUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirUsuario.Click += new System.EventHandler(this.InserirUsuario_Click);
            // 
            // tstBotoes
            // 
            this.tstBotoes.AutoSize = false;
            this.tstBotoes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tstBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tstBotoes.ImageScalingSize = new System.Drawing.Size(32, 60);
            this.tstBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserirUsuario,
            this.btnExcluir,
            this.btnAtualizar,
            this.btnSair});
            this.tstBotoes.Location = new System.Drawing.Point(0, 0);
            this.tstBotoes.Name = "tstBotoes";
            this.tstBotoes.Size = new System.Drawing.Size(55, 281);
            this.tstBotoes.TabIndex = 0;
            this.tstBotoes.Text = "toolStrip1";
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
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(69, 12);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(464, 257);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 281);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.tstBotoes);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tstBotoes.ResumeLayout(false);
            this.tstBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnInserirUsuario;
        private System.Windows.Forms.ToolStrip tstBotoes;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnExcluir;
    }
}