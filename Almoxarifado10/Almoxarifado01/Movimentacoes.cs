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
    public partial class frmMovimentacoes : Form
    {
        public frmMovimentacoes()
        {
            InitializeComponent();
        }

        private void frmMovimentacoes_Load(object sender, EventArgs e)
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
                    btnExcluir.Enabled = true;
                    break;
                case "ALTO":
                    btnExcluir.Enabled = true;
                    break;
                case "BAIXO":
                    btnExcluir.Enabled = false;
                    break;
            }

            bancoDados.Conectar();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelamovimentacao;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvMovimentacao.DataSource = bSource;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmProdutoEntrada frmProdutoEntrada = new frmProdutoEntrada();
            frmProdutoEntrada.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmProdutoSaida frmProdutoSaida = new frmProdutoSaida();
            frmProdutoSaida.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string codBarras = txtFiltro.Text;

                BancoDados bancoDados = new BancoDados();
                bancoDados.Conectar();

                Produto produto = new Produto();
                string nomeProduto = produto.RetornarNome(codBarras);

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "select * from tabelamovimentacao where produto = '" + nomeProduto + "';";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dgvMovimentacao.DataSource = bSource;
                dgvMovimentacao.Columns[0].Width = 25;
            }
        }

        private void btnFiltroEntrada_Click(object sender, EventArgs e)
        {
            string codBarras = txtFiltro.Text;

            BancoDados bancoDados = new BancoDados();
            bancoDados.Conectar();

            Produto produto = new Produto();
            string nomeProduto = produto.RetornarNome(codBarras);

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelamovimentacao where produto = '" + nomeProduto + "' and tipo = 'ENTRADA';";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvMovimentacao.DataSource = bSource;
            dgvMovimentacao.Columns[0].Width = 25;
        }

        private void btnFiltroSaida_Click(object sender, EventArgs e)
        {
            string codBarras = txtFiltro.Text;

            BancoDados bancoDados = new BancoDados();
            bancoDados.Conectar();

            Produto produto = new Produto();
            string nomeProduto = produto.RetornarNome(codBarras);

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelamovimentacao where produto = '" + nomeProduto + "' and tipo = 'SAIDA';";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvMovimentacao.DataSource = bSource;
            dgvMovimentacao.Columns[0].Width = 25;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmMovimentacoes_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idMovimentacao = Convert.ToInt32(dgvMovimentacao.CurrentRow.Cells[0].Value);
            string movimentacao = dgvMovimentacao.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir a movimentação do produto " + movimentacao + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from movimentacao where idMovimentacao = '" + idMovimentacao + "';");
                this.frmMovimentacoes_Load(sender, e);
            }
        }
    }
}
