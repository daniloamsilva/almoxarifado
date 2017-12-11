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
    public partial class frmEncontrarProduto : Form
    {
        public frmEncontrarProduto()
        {
            InitializeComponent();
        }

        private void frmEncontrarProduto_Load(object sender, EventArgs e)
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
            string sqlSelectAll = "select * from tabelaproduto;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvProduto.DataSource = bSource;
            dgvProduto.Columns[0].Width = 25;
            dgvProduto.Columns[6].Width = 500;
        }

        private void InserirProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frmCadastrarProduto = new frmCadastrarProduto();
            frmCadastrarProduto.ShowDialog();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                string codBarras = txtFiltro.Text;

                BancoDados bancoDados = new BancoDados();
                bancoDados.Conectar();

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "select * from tabelaproduto where codBarras = '"+ codBarras +"';";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dgvProduto.DataSource = bSource;
                dgvProduto.Columns[0].Width = 25;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idProduto = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
            string produto = dgvProduto.CurrentRow.Cells[2].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o produto " + produto + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from produto where idProduto = '" + idProduto + "';");
                this.frmEncontrarProduto_Load(sender, e);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmEncontrarProduto_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
