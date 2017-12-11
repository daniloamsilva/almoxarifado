namespace Almoxarifado01
{
    partial class frmMovimentacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacoes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEntrada = new System.Windows.Forms.ToolStripButton();
            this.btnSaida = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.dgvMovimentacao = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnFiltroEntrada = new System.Windows.Forms.Button();
            this.btnFiltroSaida = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEntrada,
            this.btnSaida,
            this.btnExcluir,
            this.btnAtualizar,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 314);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEntrada
            // 
            this.btnEntrada.AutoSize = false;
            this.btnEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEntrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(50, 50);
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.AutoSize = false;
            this.btnSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnSaida.Image")));
            this.btnSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(50, 50);
            this.btnSaida.Text = "Saida";
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
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
            // dgvMovimentacao
            // 
            this.dgvMovimentacao.AllowUserToAddRows = false;
            this.dgvMovimentacao.AllowUserToDeleteRows = false;
            this.dgvMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentacao.Location = new System.Drawing.Point(59, 39);
            this.dgvMovimentacao.Name = "dgvMovimentacao";
            this.dgvMovimentacao.ReadOnly = true;
            this.dgvMovimentacao.Size = new System.Drawing.Size(1060, 264);
            this.dgvMovimentacao.TabIndex = 1;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(96, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(203, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(58, 15);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Filtro:";
            // 
            // btnFiltroEntrada
            // 
            this.btnFiltroEntrada.Location = new System.Drawing.Point(306, 9);
            this.btnFiltroEntrada.Name = "btnFiltroEntrada";
            this.btnFiltroEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroEntrada.TabIndex = 4;
            this.btnFiltroEntrada.Text = "Entradas";
            this.btnFiltroEntrada.UseVisualStyleBackColor = true;
            this.btnFiltroEntrada.Click += new System.EventHandler(this.btnFiltroEntrada_Click);
            // 
            // btnFiltroSaida
            // 
            this.btnFiltroSaida.Location = new System.Drawing.Point(388, 9);
            this.btnFiltroSaida.Name = "btnFiltroSaida";
            this.btnFiltroSaida.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroSaida.TabIndex = 5;
            this.btnFiltroSaida.Text = "Saídas";
            this.btnFiltroSaida.UseVisualStyleBackColor = true;
            this.btnFiltroSaida.Click += new System.EventHandler(this.btnFiltroSaida_Click);
            // 
            // frmMovimentacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 314);
            this.Controls.Add(this.btnFiltroSaida);
            this.Controls.Add(this.btnFiltroEntrada);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvMovimentacao);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMovimentacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentações";
            this.Load += new System.EventHandler(this.frmMovimentacoes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEntrada;
        private System.Windows.Forms.ToolStripButton btnSaida;
        private System.Windows.Forms.DataGridView dgvMovimentacao;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnFiltroEntrada;
        private System.Windows.Forms.Button btnFiltroSaida;
        private System.Windows.Forms.ToolStripButton btnAtualizar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripButton btnExcluir;
    }
}