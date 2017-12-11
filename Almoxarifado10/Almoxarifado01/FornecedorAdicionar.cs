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
    public partial class frmFornecedorAdicionar : Form
    {
        public frmFornecedorAdicionar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.NomeFornecedor = txtNomeFornecedor.Text;
            fornecedor.Cnpj = maskedCnpj.Text;
            fornecedor.Cnpj = fornecedor.Cnpj.Replace(".", "");
            fornecedor.Cnpj = fornecedor.Cnpj.Replace("/", "");
            fornecedor.Cnpj = fornecedor.Cnpj.Replace("-", "");
            fornecedor.Logradouro = txtLogradouro.Text;
            fornecedor.Bairro = txtBairro.Text;
            fornecedor.Numero = txtNumero.Text;
            fornecedor.Cidade = txtCidade.Text;
            fornecedor.Contato = txtContato.Text;
            fornecedor.Telefone = maskedTelefone.Text;
            fornecedor.Telefone = fornecedor.Telefone.Replace("(", "");
            fornecedor.Telefone = fornecedor.Telefone.Replace(")", "");
            fornecedor.Telefone = fornecedor.Telefone.Replace("-", "");

            if (fornecedor.VerificarCamposFornecedor())
            {
                if (fornecedor.VerificarCnpj())
                {
                    fornecedor.CadastrarFornecedor();

                    txtNomeFornecedor.Text = "";
                    maskedCnpj.Text = "";
                    txtLogradouro.Text = "";
                    txtBairro.Text = "";
                    txtNumero.Text = "";
                    txtCidade.Text = "";
                    txtContato.Text = "";
                    maskedTelefone.Text = "";

                    MessageBox.Show("Fornecedor cadastrado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Este cnpj já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamenta.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
