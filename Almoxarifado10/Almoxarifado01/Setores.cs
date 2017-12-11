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
    public partial class frmSetores : Form
    {
        public frmSetores()
        {
            InitializeComponent();
        }

        private void frmSetores_Load(object sender, EventArgs e)
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
            string sqlSelectAll = "select * from tabelasetores;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvSetores.DataSource = bSource;
            dgvSetores.Columns[0].Width = 25;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSetoresAdicionar setoresAdicionar = new frmSetoresAdicionar();
            setoresAdicionar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmSetores_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idSetor = Convert.ToInt32(dgvSetores.CurrentRow.Cells[0].Value);
            string setor = dgvSetores.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o setor " + setor + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from setordestino where idSetor = '" + idSetor + "';");
                this.frmSetores_Load(sender, e);
            }
        }
    }
}
