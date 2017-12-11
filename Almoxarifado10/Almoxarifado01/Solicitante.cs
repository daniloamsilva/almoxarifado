using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado01
{
    class Solicitante
    {
        //Atributos da classe
        private int idSolicitante;
        private string nome;
        private int idSetorDestino;

        //Metodos get e set
        public int IdSolicitante { get => idSolicitante; set => idSolicitante = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdSetorDestino { get => idSetorDestino; set => idSetorDestino = value; }

        public int RetornarID(string nomeSolicitante)
        {
            this.nome = nomeSolicitante;
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select * from solicitante where nome='" + this.nome + "';");


            while (query.Read())
            {
                this.idSolicitante = query.GetInt32("idSolicitante");
            }
            return idSolicitante;
        }

        public void CadastrarSolicitante()
        {
            BancoDados bancoDados = new BancoDados();
            bancoDados.Inserir("insert into solicitante (nome, SetorDestino_idSetor) values('" + this.nome + "'," + this.idSetorDestino + ");"); //Instrução de insert into para o banco.
        }
    }
}
