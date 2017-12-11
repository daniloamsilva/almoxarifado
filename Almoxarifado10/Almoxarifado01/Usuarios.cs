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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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
                    btnInserirUsuario.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
                case "ALTO":
                    btnInserirUsuario.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
                case "BAIXO":
                    btnInserirUsuario.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
            }

            bancoDados.Conectar();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "select * from tabelausuario;";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, bancoDados.Connection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dgvUsuarios.DataSource = bSource;
            dgvUsuarios.Columns[0].Width = 25;
        }

        private void InserirUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioAdicionar usuarioCriar = new frmUsuarioAdicionar();
            usuarioCriar.ShowDialog();
        }

        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.frmUsuarios_Load(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Variavel que recebe a linha escolhida pelo usuário
            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            string usuario = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();

            // Mensagem para confirmar a exclusão
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja excluir o usuário " + usuario + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult.ToString().Equals("Yes"))
            {
                // Código para exclusão
                BancoDados bancoDados = new BancoDados();
                bancoDados.Excluir("delete from usuario where idUsuario = '" + idUsuario + "';");
                this.frmUsuarios_Load(sender, e);
            }
        }
    }
}
