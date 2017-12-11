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
    public partial class frmPrateleiraAdicionar : Form
    {
        public frmPrateleiraAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Prateleira prateleira = new Prateleira(); // Instância da classe prateleira

            prateleira.Localizacao = txtLocalizacao.Text; // Localização digitada pelo usúario

            if (prateleira.VerificarLocalizacao())
            {
                prateleira.CadastrarPrateleira(); // Método para cadastro

                txtLocalizacao.Text = "";

                // Mensagem informando o sucesso do cadastro
                MessageBox.Show("Prateleira cadastrada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensagem informando ao usuário sobre a existência da prateleira
                MessageBox.Show("Essa prateleira já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
