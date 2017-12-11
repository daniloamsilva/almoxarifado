using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almoxarifado01
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmSalvarBackup_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            this.btnSalvarBackup = new System.Windows.Forms.Button();
            this.btnRestaurarBackup = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.lblCodigoBackup = new System.Windows.Forms.Label();
            this.lblDataBackup = new System.Windows.Forms.Label();
            this.grbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvarBackup
            // 
            this.btnSalvarBackup.Location = new System.Drawing.Point(14, 19);
            this.btnSalvarBackup.Name = "btnSalvarBackup";
            this.btnSalvarBackup.Size = new System.Drawing.Size(124, 23);
            this.btnSalvarBackup.TabIndex = 0;
            this.btnSalvarBackup.Text = "Salvar Backup";
            this.btnSalvarBackup.UseVisualStyleBackColor = true;
            // 
            // btnRestaurarBackup
            // 
            this.btnRestaurarBackup.Location = new System.Drawing.Point(14, 48);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.btnRestaurarBackup.Size = new System.Drawing.Size(124, 23);
            this.btnRestaurarBackup.TabIndex = 0;
            this.btnRestaurarBackup.Text = "Restaurar Backup";
            this.btnRestaurarBackup.UseVisualStyleBackColor = true;
            // 
            // grbControles
            // 
            this.grbControles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grbControles.Controls.Add(this.btnSalvarBackup);
            this.grbControles.Controls.Add(this.btnRestaurarBackup);
            this.grbControles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbControles.Location = new System.Drawing.Point(196, 12);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(150, 82);
            this.grbControles.TabIndex = 1;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles";
            // 
            // lblCodigoBackup
            // 
            this.lblCodigoBackup.AutoSize = true;
            this.lblCodigoBackup.Location = new System.Drawing.Point(23, 41);
            this.lblCodigoBackup.Name = "lblCodigoBackup";
            this.lblCodigoBackup.Size = new System.Drawing.Size(138, 13);
            this.lblCodigoBackup.TabIndex = 2;
            this.lblCodigoBackup.Text = "Código do backup: [codigo]";
            this.lblCodigoBackup.Click += new System.EventHandler(this.lblCodigoBackup_Click);
            // 
            // lblDataBackup
            // 
            this.lblDataBackup.AutoSize = true;
            this.lblDataBackup.Location = new System.Drawing.Point(23, 60);
            this.lblDataBackup.Name = "lblDataBackup";
            this.lblDataBackup.Size = new System.Drawing.Size(141, 13);
            this.lblDataBackup.TabIndex = 2;
            this.lblDataBackup.Text = "Data: data do último backup";
            // 
            // frmBackup
            // 
            this.ClientSize = new System.Drawing.Size(358, 113);
            this.Controls.Add(this.lblDataBackup);
            this.Controls.Add(this.lblCodigoBackup);
            this.Controls.Add(this.grbControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmSalvarBackup_Load_1);
            this.grbControles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmSalvarBackup_Load_1(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select privilegio from usuario where login = 'ON';");
            string privilegio = "";

            while (query.Read())
            {
                privilegio = query.GetString("privilegio");
            }

            switch (privilegio)
            {
                case "TOTAL":
                    btnRestaurarBackup.Enabled = true;
                    break;
                case "ALTO":
                    btnRestaurarBackup.Enabled = false;
                    break;
                case "BAIXO":
                    btnRestaurarBackup.Enabled = false;
                    break;
            }

        }

        private void lblCodigoBackup_Click(object sender, EventArgs e)
        {

        }
    }
}
