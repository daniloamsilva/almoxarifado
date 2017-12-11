using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Almoxarifado01
{
    class SetorDestino
    {
        //ATRIBUTOS
        private int idSetorDestino;
        private string nomeSetor;

        //METODOS GET E SET
        public int IdSetorDestino { get => idSetorDestino; set => idSetorDestino = value; }
        public string NomeSetor { get => nomeSetor; set => nomeSetor = value; }

        //Metodo para validação do nome do setor,
        //que retorna false se o campo estiver vazio.
        public bool VerificarNomeVazio ()
        {
            if (this.nomeSetor == "") {
                return false;
            }
            return true;
        }

        //Metodo para cadastrar um Setor.
        public bool VerificarNome()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from setordestino where nomeSetor='" + this.nomeSetor + "';"); //Resultado é atribuido na variavel query.
            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd > 0) //Caso o qtd seja meior que zero, significa que há setores cadastrados com o mesmo nome.
                {
                    return false;
                }
            }
            
            return true;
        }

        public void CadastrarSetor()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into setorDestino (nomeSetor) values('" + this.nomeSetor + "');"); //Instrução de insert into para o banco.
        }

        public int RetornarID(string nomeSetor)
        {
            this.nomeSetor = nomeSetor;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from setorDestino where NomeSetor = '" + this.nomeSetor + "';");


            while (query.Read())
            {
                this.idSetorDestino = query.GetInt32("idSetor");
            }
            return idSetorDestino;
        }
    }
}
