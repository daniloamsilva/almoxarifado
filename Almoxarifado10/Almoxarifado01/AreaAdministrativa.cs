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
    public partial class AreaAdministrativa : Form
    {
        public AreaAdministrativa()
        {
            InitializeComponent();
        }

        //Variaveis para controle dos forms.
        frmBackup salvarBackup;
        frmCadastrarProduto cadastrarProduto;
        frmEstoque estoque;
        frmAvisos avisos;
        frmEncontrarProduto encontrarProduto;
        frmFornecedores fornecedores;
        frmMovimentacoes movimentacoes;
        frmPrateleiras prateleiras;
        frmSetores setores;
        frmUnidades unidades;
        frmUsuarios usuarios;
        frmSolicitantes solicitantes;

        private void AreaAdministrativa_Load(object sender, EventArgs e)
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
                    listarUsuárioToolStripMenuItem.Enabled = true;
                    break;
                case "ALTO":
                    listarUsuárioToolStripMenuItem.Enabled = true;
                    break;
                case "BAIXO":
                    listarUsuárioToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        // Troca o nome do usuário logado
        public void LogarUsuario(string nome)
        {
            lblUsuarioAtivo.Text = nome;
        }

        //BACKUP
        private void salvarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frmBackup>().Count() == 0)
            {
                salvarBackup = new frmBackup
                {
                    MdiParent = this
                };
                salvarBackup.Show();
            }
            salvarBackup.Focus();
        }

        //CADASTRAR PRODUTO
        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadastrarProduto>().Count() == 0)
            {
                cadastrarProduto = new frmCadastrarProduto
                {
                    MdiParent = this
                };
                cadastrarProduto.Show();
            }
            cadastrarProduto.Focus();
        }

        //ALTERAR PRODUTO
        private void alterarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEstoque>().Count() == 0)
            {
                estoque = new frmEstoque
                {
                    MdiParent = this
                };
                estoque.Show();
            }
            estoque.Focus();
        }

        //LOGIN
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        //MOVIMENTAÇÕES
        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMovimentacoes>().Count() == 0)
            {
                movimentacoes = new frmMovimentacoes
                {
                    MdiParent = this
                };
                movimentacoes.Show();
            }
            movimentacoes.Focus();
        }

        //PRATELEIRAS
        private void prateleirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPrateleiras>().Count() == 0)
            {
                prateleiras = new frmPrateleiras
                {
                    MdiParent = this
                };
                prateleiras.Show();
            }
            prateleiras.Focus();
        }

        //SETORES
        private void setoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSetores>().Count() == 0)
            {
                setores = new frmSetores
                {
                    MdiParent = this
                };
                setores.Show();
            }
            setores.Focus();
        }

        //USUARIOS
        private void úsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //ENCONTRAR PRODUTO
        private void encontrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEncontrarProduto>().Count() == 0)
            {
                encontrarProduto = new frmEncontrarProduto
                {
                    MdiParent = this
                };
                encontrarProduto.Show();
            }
            encontrarProduto.Focus();
        }

        //UNIDADES
        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmUnidades>().Count() == 0)
            {
                unidades = new frmUnidades
                {
                    MdiParent = this
                };
                unidades.Show();
            }
            unidades.Focus();
        }

        //FORNECEDORES
        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedores>().Count() == 0)
            {
                fornecedores = new frmFornecedores
                {
                    MdiParent = this
                };
                fornecedores.Show();
            }
            fornecedores.Focus();
        }

        //AVISOS
        private void avisosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAvisos>().Count() == 0)
            {
                avisos = new frmAvisos
                {
                    MdiParent = this
                };
                avisos.Show();
            }
            avisos.Focus();
        }

        //LISTAR USUARIOS
        private void listarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmUsuarios>().Count() == 0)
            {
                usuarios = new frmUsuarios
                {
                    MdiParent = this
                };
                usuarios.Show();
            }
            usuarios.Focus();
        }

        //ATALHO PRODUTOS
        private void atalhoProdutos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEncontrarProduto>().Count() == 0)
            {
                encontrarProduto = new frmEncontrarProduto
                {
                    MdiParent = this
                };
                encontrarProduto.Show();
            }
            encontrarProduto.Focus();
        }

        //ATALHO MOVIMENTAÇÕES
        private void atalhoMovimentacoes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMovimentacoes>().Count() == 0)
            {
                movimentacoes = new frmMovimentacoes
                {
                    MdiParent = this
                };
                movimentacoes.Show();
            }
            movimentacoes.Focus();
        }

        //ATALHO FORNECEDORES
        private void atalhoFornecedores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFornecedores>().Count() == 0)
            {
                fornecedores = new frmFornecedores
                {
                    MdiParent = this
                };
                fornecedores.Show();
            }
            fornecedores.Focus();
        }

        //ATALHO AVISOS
        private void atalhoAvisos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAvisos>().Count() == 0)
            {
                avisos = new frmAvisos
                {
                    MdiParent = this
                };
                avisos.Show();
            }
            avisos.Focus();
        }

        //ATALHO LOGIN
        private void atalhoUsuario_Click(object sender, EventArgs e)
        {
            frmLoginAlterar loginAlterar = new frmLoginAlterar();
            loginAlterar.ShowDialog();
        }

        //ATALHO SAIR
        private void atalhoSair_Click(object sender, EventArgs e)
        {
            //Message box para alertar o úsuario que esta saindo do programa.
            DialogResult dialogResult = MessageBox.Show("Deseja sair do programa?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            //Condição para verificação da resposta do úsuario.
            if (dialogResult.ToString().Equals("Yes"))
            {
                BancoDados bancoDados = new BancoDados();
                bancoDados.Consultar("update usuario set login = 'OFF' where login = 'ON';");
                Application.Exit();
            }
        }

        private void AreaAdministrativa_FormClosing(object sender, FormClosingEventArgs e)
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Consultar("update usuario set login = 'OFF' where login = 'ON';");
            Application.Exit();
        }

        private void solicitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSolicitantes>().Count() == 0)
            {
                solicitantes = new frmSolicitantes
                {
                    MdiParent = this
                };
                solicitantes.Show();
            }
            solicitantes.Focus();
        }

        private void mudarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAlterar loginAlterar = new frmLoginAlterar();
            loginAlterar.ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocarSenha trocarSenha = new frmTrocarSenha();
            trocarSenha.ShowDialog();
        }

        private void AreaAdministrativa_Activated(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados(); // Instância da classe do banco de dados
            MySqlDataReader query = bancoDados.Consultar("select nome from usuario where login = 'ON';");
            string usuario = "";

            while (query.Read())
            {
                usuario = query.GetString("nome");
            }

            this.LogarUsuario(usuario);
            this.lblBancoDados.Text = bancoDados.Server;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }
    }
}