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
    public partial class frmPrateleiras : Form
    {
        public frmPrateleiras()
        {
            InitializeComponent();
        }

        private void frmPrateleiras_Load(object sender, EventArgs e)
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
            string sqlSelectAll = "select * from tabelaprateleira;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvPrateleira.DataSource = bSource;
            dgvPrateleira.Columns[0].Width = 25;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPrateleiraAdicionar prateleiraAdicionar = new frmPrateleiraAdicionar();
            prateleiraAdicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmPrateleiras_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idPrateleira = Convert.ToInt32(dgvPrateleira.CurrentRow.Cells[0].Value);
            string prateleira = dgvPrateleira.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir a prateleira " + prateleira + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from prateleira where idPrateleira = '" + idPrateleira + "';");
                this.frmPrateleiras_Load(sender, e);
            }
        }
    }
}