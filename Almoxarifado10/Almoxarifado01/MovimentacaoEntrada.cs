using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Almoxarifado01
{
    public partial class frmProdutoEntrada : Form
    {
        public frmProdutoEntrada()
        {
            InitializeComponent();
        }

        private void frmProdutoEntrada_Load(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados(); // Instância da classe do banco de dados

            // Código para o combobox das Prateleiras
            MySqlDataReader query = bancoDados.Consultar("select * from prateleira order by localizacao;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("localizacao");
                cbPrateleira.Items.Add(thisrow);
            }

            // Código para o combobox dos Solicitantes
            query = bancoDados.Consultar("select * from solicitante order by nome;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("nome");
                cbSolicitante.Items.Add(thisrow);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instâncias das classes usadas
            Movimentacao movimentacao = new Movimentacao();
            Produto produto = new Produto();
            Prateleira prateleira = new Prateleira();
            Solicitante solicitante = new Solicitante();
            Usuario usuario = new Usuario();

            // Passagem dos dados digitados para a classe movimentação
            movimentacao.IdProduto = produto.RetornarID(txtCodBarras.Text);
            movimentacao.IdPrateleira = prateleira.RetornarID(cbPrateleira.Text);
            movimentacao.IdUsuario = usuario.UsuarioLogado();
            movimentacao.IdSolicitante = solicitante.RetornarID(cbSolicitante.Text);
            movimentacao.Validade = maskedtxtValidade.Text;
            movimentacao.Quantidade = Convert.ToInt32(numericQuant.Value);
            movimentacao.Preco = txtPreco.Text.Replace(",",".");

            // Tratamento do campo validade
            string[] validade = movimentacao.Validade.Split('/');
            movimentacao.Validade = validade[1] + "-" + validade[0] + "-01";

            // Código para entrada da movimentação
            movimentacao.CadastrarMovimentacao("ENTRADA");

            // Limpeza dos campos da tela
            txtCodBarras.Text = "";
            cbPrateleira.Text = "";
            cbSolicitante.Text = "";
            maskedtxtValidade.Text = "";
            numericQuant.Value = 0;
            txtPreco.Text = "";

            // Mensagem para o usuário informando o sucesso do cadastro
            MessageBox.Show("Entrada efetuada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
