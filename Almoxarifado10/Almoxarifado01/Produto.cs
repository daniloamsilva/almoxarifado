using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado01
{
    class Produto
    {
        //Atributos da classe
        private int idProduto;
        private Unidade unidade; //atributo referencia (Unidade)
        private Fornecedor fornecedor; //atributo referencia (Fornecedor)
        private string codBarras;
        private string nome;
        private string descricao;
        private int qtdMinima;

        public Produto()
        {
            this.unidade = new Unidade();
            

        }
        //Metodos get e set
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string CodBarras { get => codBarras; set => codBarras = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int QtdMinima { get => qtdMinima; set => qtdMinima = value; }
        public Unidade Unidade { get => unidade; set => unidade = value; }
        public Fornecedor Fornecedor { get => fornecedor; set => fornecedor = value; }

        //Metodo para validação de produto.
        public bool ValidarProduto()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from produto where codBarras='" + this.codBarras + "';"); //Resultado é atribuido na variavel query.

            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd > 0) //Caso o qtd seja menor ou igual a zero, significa que não há produtos cadastrados com o código de barras.
                {
                    return false;
                }
            }
            return true;
        }

        public void CadastrarProduto()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into produto(Unidade_idUnidade, Fornecedor_idFornecedor, codBarras, nome, descricao, qtdMinima)" +
                "values('" + this.unidade.IdUnidade +"','" + this.fornecedor.IdFornecedor + "','" + this.codBarras + "','" + this.nome + "','" + this.descricao + "','" + this.qtdMinima +"');");
        }

        public int RetornarID(string codBarras)
        {
            this.codBarras = codBarras;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from produto where codBarras = " + this.codBarras + ";");


            while (query.Read())
            {
                this.idProduto = query.GetInt32("idProduto");
            }
            return idProduto;
        }

        public string RetornarNome(string codBarras)
        {
            this.codBarras = codBarras;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from produto where codBarras = " + this.codBarras + ";");

            while (query.Read())
            {
                this.nome = query.GetString("nome");
            }
            return nome;
        }
    }
}
