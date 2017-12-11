using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Almoxarifado01
{
    class Unidade
    {
        //Atributos da classe
        private int idUnidade;
        private string nomeUnidade;
        private string descricao;

        //Metodos get e set
        public int IdUnidade { get => idUnidade; set => idUnidade = value; }
        public string NomeUnidade { get => nomeUnidade; set => nomeUnidade = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        //Metodos da classe
        public bool VerificarUnidade()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from unidade where nomeUnidade='" + this.nomeUnidade + "';"); //Resultado é atribuido na variavel query.
            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd > 0) //Caso o qtd seja meior que zero, significa que há unidades cadastrados com o mesmo nome.
                {
                    return false;
                }
            }
            return true;
        }

        public bool VerificarDescricao()
        {
            //Verifica se a descrição tem mais de 100 digitos
            if(this.descricao.Length > 100)
            {
                return false;
            }
            return true;
        }

        public void CadastrarUnidade()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into unidade (nomeUnidade,descricao) values('" + this.nomeUnidade + "','" + this.descricao + "');"); //Instrução de insert into para o banco.
        }

        public Unidade RetornarID(string nomeUnidade)
        {
            Unidade unidade = new Unidade();
            unidade.nomeUnidade = nomeUnidade;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select idUnidade from unidade where nomeUnidade='" + nomeUnidade + "';");
          

            while (query.Read())
            {
                unidade.idUnidade= query.GetInt32("idUnidade");
            }
            return unidade;
        }
    }
}
