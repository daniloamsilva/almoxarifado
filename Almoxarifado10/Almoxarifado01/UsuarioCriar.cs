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
    public partial class frmUsuarioAdicionar : Form
    {
        public frmUsuarioAdicionar()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = txtNomeUsuario.Text;
            usuario.Senha1 = txtSenha1.Text;
            usuario.Senha2 = txtSenha2.Text;
            usuario.Email = txtEmail.Text;
            usuario.Cpf = maskedtxtCpf.Text;
            usuario.Cpf = usuario.Cpf.Replace(".", "");
            usuario.Cpf = usuario.Cpf.Replace("-", "");
            usuario.Privilegio = cbPrivilegio.Text;
            
            if (usuario.VerificarSenha(usuario.Senha1))
            {
                if (usuario.ValidarSenha(usuario.Senha1, usuario.Senha2))
                {
                    if (usuario.VerificarCpf(usuario.Cpf))
                    {
                        usuario.CadastrarUsuario();

                        txtNomeUsuario.Text = "";
                        txtSenha1.Text = "";
                        txtSenha2.Text = "";
                        maskedtxtCpf.Text = "";
                        txtEmail.Text = "";
                        cbPrivilegio.Text = "";

                        MessageBox.Show("Usuário cadastrado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF já cadastrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não conferem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Senha deve conter 6 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void lblSenha2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarioAdicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
