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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados(); // Instância da classe do banco de dados

            // Código para o combobox das Usuário
            MySqlDataReader query = bancoDados.Consultar("select * from usuario order by nome;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("nome");
                cbUsuario.Items.Add(thisrow);
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            
            //LEITURA DO USUARIO DE SENHA DIGITADOS
            String usuario = cbUsuario.Text;
            String senha = textBoxSenha.Text;

            //NOME DO USUARIO SERÁ PASSADO PARA O STATUS STRIP
            AreaAdministrativa areaAdministrativa = new AreaAdministrativa();
            areaAdministrativa.LogarUsuario(usuario);

            //CÓDIGO PARA O UPDATE NO BANCO DE DADOS
            BancoDados bancoDados = new BancoDados();
            bancoDados.Consultar("update usuario set login = 'ON' where nome ='"+ usuario + "';");

            Usuario classeUsuario = new Usuario();

            //VERIFICAÇÃO DE LOGIN
            if (classeUsuario.VerificarSenhaLogin(usuario,senha))
            {
                this.Hide();
                areaAdministrativa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha incorreta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
