using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almoxarifado01
{
    class Fornecedor
    {
        //Atributos da classe
        private int idFornecedor;
        private string nomeFornecedor;
        private string contato;
        private string cnpj;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string numero;
        private string telefone;

        //Metodos get e set;
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
        public string Contato { get => contato; set => contato = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        //Metodos da classe
        public bool VerificarCamposFornecedor()
        {
            if(this.nomeFornecedor == "" || this.contato == "" || this.cnpj == "" || this.logradouro == "" || this.bairro == "" || 
                this.cidade == "" || this.numero == "" || this.telefone == "")
            {
                return false;
            }
            return true;
        }

        public bool VerificarCnpj ()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from fornecedor where cnpj='" + this.cnpj + "';"); //Resultado é atribuido na variavel query.
            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd > 0) //Caso o qtd seja meior que zero, significa que há esse cnpj cadastrado.
                {
                    return false;
                }
            }
           
            return true;
        }

        public bool CadastrarFornecedor ()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into fornecedor(nomeFornecedor,contato,cnpj,logradouro,bairro,cidade,numero,telefone)" +
                "values('" + this.nomeFornecedor +"','" + this.contato + "','" + this.cnpj + "','" + this.logradouro + "','" + this.bairro +
                "','" + this.cidade + "','" + this.numero + "','" + this.telefone + "');");
            return true;
        }

        public Fornecedor RetornarId(string nomeFornecedor)
        {
            Fornecedor f = new Fornecedor();
            f.nomeFornecedor = nomeFornecedor;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select idFornecedor from fornecedor where nomeFornecedor='" + nomeFornecedor + "';");


            while (query.Read())
            {
                f.idFornecedor = query.GetInt32("idFornecedor");
            }
            return f;
        }
    }
}
