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
    public partial class frmLoginAlterar : Form
    {
        public frmLoginAlterar()
        {
            InitializeComponent();
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
            bancoDados.Atualizar("update usuario set login = 'OFF' where login = 'ON';");
            bancoDados.Atualizar("update usuario set login = 'ON' where nome ='" + usuario + "';");

            Usuario classeUsuario = new Usuario();

            //VERIFICAÇÃO DE LOGIN
            if (classeUsuario.VerificarSenhaLogin(usuario, senha))
            {
                if (Application.OpenForms.OfType<AreaAdministrativa>().Count() == 1)
                {
                    areaAdministrativa.Focus();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLoginAlterar_Load(object sender, EventArgs e)
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
