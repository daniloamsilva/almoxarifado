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
    public partial class frmTrocarSenha : Form
    {
        public frmTrocarSenha()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            // Classes utilizadas
            BancoDados bancoDados = new BancoDados();
            Usuario usuario = new Usuario();

            // Código para identificar o usuário logado
            int idUsuario = 0;
            MySqlDataReader query = bancoDados.Consultar("select idUsuario from usuario where login ='ON';");
            while (query.Read())
            {
                idUsuario = query.GetInt32("idUsuario");
            }

            // Leitura das senhas digitadas pelo usuário
            string senhaatual = txtSenhaAtual.Text;
            string senhaNova1 = txtNovaSenha1.Text;
            string senhaNova2 = txtSenhaNova2.Text;

            // Verificação de senha
            if(usuario.VerificarSenha(senhaNova1))
            {
                if(usuario.ValidarSenha(senhaNova1, senhaNova2))
                {
                    // Método para troca da senha
                    usuario.TrocarSenha(senhaNova1, idUsuario);

                    // Limpeza dos campos da tela
                    txtSenhaAtual.Text = "";
                    txtNovaSenha1.Text = "";
                    txtSenhaNova2.Text = "";

                    // Mensagem informando o sucesso da troca
                    MessageBox.Show("Troca efetuada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mensagem informando erro nas senhas
                    MessageBox.Show("Senhas não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Mensagem informando erro nos número de digitos
                MessageBox.Show("Senha deve conter 6 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
