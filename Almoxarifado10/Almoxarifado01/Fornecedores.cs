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
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void frmFornecedores_Load(object sender, EventArgs e)
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
                    AdicionarFornecedor.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "ALTO":
                    AdicionarFornecedor.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "BAIXO":
                    AdicionarFornecedor.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
            }

            bancoDados.Conectar();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelafornecedor;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvFornecedor.DataSource = bSource;
            dgvFornecedor.Columns[0].Width = 25;
        }

        private void AdicionarFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorAdicionar fornecedorAdicionar = new frmFornecedorAdicionar();
            fornecedorAdicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmFornecedores_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idFornecedor = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
            string fornecedor = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o fornecedor " + fornecedor + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from fornecedor where idFornecedor = '" + idFornecedor + "';");
                this.frmFornecedores_Load(sender, e);
            }
        }
    }
}
