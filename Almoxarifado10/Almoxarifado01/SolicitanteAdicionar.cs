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
    public partial class frmSolicitanteAdicionar : Form
    {
        public frmSolicitanteAdicionar()
        {
            InitializeComponent();
        }

        private void frmSolicitanteAdicionar_Load(object sender, EventArgs e)
        {
            BancoDados bancoDados = new BancoDados(); // Instância da classe do banco de dados

            // Código para o combobox dos Setores
            MySqlDataReader query = bancoDados.Consultar("select * from setorDestino order by nomeSetor;");

            while (query.Read())
            {
                string thisrow = "";

                thisrow += query.GetString("nomeSetor");
                cbSetor.Items.Add(thisrow);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Classes utilizadas
            Solicitante solicitante = new Solicitante();
            SetorDestino setorDestino = new SetorDestino();

            // Leitura dos campos digitados pelo usuário
            solicitante.Nome = txtNome.Text;
            solicitante.IdSetorDestino = setorDestino.RetornarID(cbSetor.Text);

            // Método de cadastro do solicitante
            solicitante.CadastrarSolicitante();

            // Limpeza dos campos da tela
            txtNome.Text = "";
            cbSetor.Text = "";

            // Mensagem informando ao usuário o sucesso do cadastro
            MessageBox.Show("Solicitante cadastrado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
