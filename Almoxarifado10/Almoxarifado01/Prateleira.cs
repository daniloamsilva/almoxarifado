using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Almoxarifado01
{
    class Prateleira
    {
        //Atributos da classe
        private int idPrateleira;
        private string localizacao;

        //Metodos get e set
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public int IdPrateleira { get => idPrateleira; set => idPrateleira = value; }

        //Metodos da classe
        public bool VerificarLocalizacao()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from prateleira where localizacao='" + this.localizacao + "';"); //Resultado é atribuido na variavel query.
            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd > 0) //Caso o qtd seja meior que zero, significa que há prateleiras cadastradas com o mesmo nome.
                {
                    return false;
                }
            }

            return true;
        }

        public void CadastrarPrateleira()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into prateleira (localizacao) values('" + this.localizacao + "');"); //Instrução de insert into para o banco.
        }

        public int RetornarID(string localizacao)
        {
            this.localizacao = localizacao;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from prateleira where localizacao='" + this.localizacao + "';");


            while (query.Read())
            {
                this.idPrateleira = query.GetInt32("idPrateleira");
            }
            return idPrateleira;
        }
    }
}
