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
    public partial class frmUnidadeAdicionar : Form
    {
        public frmUnidadeAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Unidade unidade = new Unidade(); //instância da classse unidade

            //Armazenamento dos dados digitados nos repectivos atributos da classe
            unidade.NomeUnidade = txtNomeUnidade.Text;
            unidade.Descricao = txtDescricao.Text;

            if (unidade.VerificarUnidade()) //Teste para verificar se já existe uma unidade com esse nome
            {
                if (unidade.VerificarDescricao())
                {
                    unidade.CadastrarUnidade(); //Método para cadastro da unidade

                    //Limpeza dos campos de texto
                    txtNomeUnidade.Text = "";
                    txtDescricao.Text = "";
                    
                    //Mensasgem de sucesso do cadastro
                    MessageBox.Show("Cadastro efetuado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Mensagem para informar uma descrição muito grande
                    MessageBox.Show("Descrição possui mais de 100 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //Mensagem de informação para úsuario, informando a existência da unidade no banco
                MessageBox.Show("Existe uma unidade com esse nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmUnidadeAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
