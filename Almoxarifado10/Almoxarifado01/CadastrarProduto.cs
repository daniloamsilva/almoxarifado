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
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from fornecedor order by nomeFornecedor;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("nomeFornecedor");
                cbFornecedor.Items.Add(thisrow);
            }

            query = bancoDados.Consultar("select * from unidade order by nomeUnidade;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("nomeUnidade");
                cbUnidade.Items.Add(thisrow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(); // Instância da classe produto
            Unidade unidade = new Unidade();
            Fornecedor fornecedor = new Fornecedor();

            produto.Nome = txtNomeProduto.Text;
            produto.CodBarras = txtCodBarras.Text;
            produto.Descricao = txtDescricao.Text;
            produto.QtdMinima = Convert.ToInt32(quantMinima.Value);
            produto.Unidade = unidade.RetornarID(cbUnidade.Text);
            produto.Fornecedor = fornecedor.RetornarId(cbFornecedor.Text);

            if (produto.ValidarProduto())
            {
                produto.CadastrarProduto();

                txtNomeProduto.Text = "";
                txtCodBarras.Text = "";
                txtDescricao.Text = "";
                quantMinima.Value = 0;
                cbUnidade.Text = "";
                cbFornecedor.Text = "";

                MessageBox.Show("Produto cadastrado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mensagem informando que o produto já existe
                MessageBox.Show("Este código de barras já esta cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
