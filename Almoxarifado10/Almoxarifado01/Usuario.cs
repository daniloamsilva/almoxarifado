using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Almoxarifado01
{
    class Usuario
    {
        //Atributos da classe
        private int idUsuario;
        private string nome;
        private string email;
        private string cpf;
        private string privilegio;
        private string senha1;
        private string senha2;
        
        //Metodos get e set
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Senha1 { get => senha1; set => senha1 = value; }
        public string Senha2 { get => senha2; set => senha2 = value; }
        public string Privilegio { get => privilegio; set => privilegio = value; }

        //Metodos da classe
        public bool VerificarSenha(string senha)
        {
            if (senha.Length == 6 )
            {
                return true;
            }
           
            return false;
           
        }

        public bool VerificarCpf(string cpf)
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            MySqlDataReader query = bancoDados.Consultar("select count(*) as qtd from usuario where cpf='" + cpf + "';"); //Resultado é atribuido na variavel query.

            while (query.Read()) //Laço para leitura do resultado.
            {
                int qtd = query.GetInt32("qtd"); //Atribui o valor de gtd para a variavel qtd.
                if (qtd == 0) //Caso o qtd seja menor ou igual a zero, significa que não há usuários cadastrados com o cpf.
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidarSenha(string senha1, string senha2)
        {
            if (senha1 == senha2)
            {
                return true;
            }
            return false;
        }

        public bool CadastrarUsuario()
        {
            BancoDados bancoDados = new BancoDados(); //Instância do banco de dados.
            bancoDados.Inserir("insert into usuario(nome,email,cpf,senha,privilegio,login)" +
                "values('" + this.nome.ToUpper() + "','" + this.email + "','" + this.cpf + "','" + this.senha1 + "','" + this.privilegio + "','" + "OFF" + "');");
            return true;
        }

        public bool VerificarSenhaLogin(string nomeUsuario, string senha)
        {
            this.nome = nomeUsuario;
            this.senha1 = senha;

            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select senha from usuario where nome ='" + nomeUsuario + "';");
            
            while (query.Read())
            {
                this.senha2 = query.GetString("senha");
            }
            
            if(senha1 == senha2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RetornarID(string nome)
        {
            Usuario usuario = new Usuario();
            usuario.nome = nome;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select idUsuario from usuario where nome ='" + nome + "';");


            while (query.Read())
            {
                usuario.idUsuario = query.GetInt32("idUsuario");
            }
            return idUsuario;
        }

        public int UsuarioLogado()
        {
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from usuario where login = 'ON';");

            while (query.Read())
            {
                this.idUsuario = query.GetInt32("idUsuario");
            }
            return idUsuario;
        }

        public void TrocarSenha(string senhaNova , int idUsuario)
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Atualizar("update usuario set senha = '"+ senhaNova +"' where idUsuario = "+ idUsuario +";");
        }
    }
}
