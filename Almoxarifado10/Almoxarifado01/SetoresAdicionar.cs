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
    public partial class frmSetoresAdicionar : Form
    {
        public frmSetoresAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SetorDestino setorDestino = new SetorDestino(); // Instância da classe setorDestino

            setorDestino.NomeSetor = txtNomeSetor.Text; // Nome digitado pelo usuário

            if (setorDestino.VerificarNomeVazio()) // Teste para verificar se um nome foi digitado
            {
                if (setorDestino.VerificarNome()) // Teste para verificar se o setor já existe no banco de dados
                {
                    setorDestino.CadastrarSetor(); // Método de cadastro

                    txtNomeSetor.Text = ""; // Limpeza do campo nome

                    // Mensagem de sucesso no cadastro
                    MessageBox.Show("Setor cadastrado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mensagem ao usuário informando que o setor já existe
                    MessageBox.Show("Este setor já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Mensagem ao usuário informando que o campo do nome esta vazio
                MessageBox.Show("Digite um nome para o setor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
