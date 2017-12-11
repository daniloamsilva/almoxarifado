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
    public partial class frmSolicitantes : Form
    {
        public frmSolicitantes()
        {
            InitializeComponent();
        }

        private void Solicitantes_Load(object sender, EventArgs e)
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
            string sqlSelectAll = "select * from tabelasolicitante;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvSolicitante.DataSource = bSource;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmSolicitanteAdicionar solicitanteAdicionar = new frmSolicitanteAdicionar();
            solicitanteAdicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Solicitantes_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idSolicitante = Convert.ToInt32(dgvSolicitante.CurrentRow.Cells[0].Value);
            string solicitante = dgvSolicitante.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o solicitante " + solicitante + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from solicitante where idSolicitante = '" + idSolicitante + "';");
                this.Solicitantes_Load(sender, e);
            }
        }
    }
}
