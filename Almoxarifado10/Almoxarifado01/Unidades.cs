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
    public partial class frmUnidades : Form
    {
        public frmUnidades()
        {
            InitializeComponent();
        }

        private void frmUnidades_Load(object sender, EventArgs e)
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
                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "ALTO":
                    btnAdicionar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "BAIXO":
                    btnAdicionar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
            }

            bancoDados.Conectar();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelaunidade;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvUnidade.DataSource = bSource;
            dgvUnidade.Columns[0].Width = 25;
            dgvUnidade.Columns[2].Width = 200;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUnidadeAdicionar unidadesAdicionar = new frmUnidadeAdicionar();
            unidadesAdicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmUnidades_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idUnidade = Convert.ToInt32(dgvUnidade.CurrentRow.Cells[0].Value);
            string unidade = dgvUnidade.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir a unidade " + unidade + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from unidade where idUnidade = '" + idUnidade + "';");
                this.frmUnidades_Load(sender, e);
            }
        }
    }
}
