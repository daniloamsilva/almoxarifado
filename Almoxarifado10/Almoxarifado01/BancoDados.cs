using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Almoxarifado01
{
    class BancoDados
    {
        //Atributos da classe
        private string server = "localhost";
        private string database = "almoxarifadodb";
        private string uid = "root";
        private string password = "root";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader query;

        public MySqlConnection Connection { get => connection; set => connection = value; }
        public string Server { get => server; set => server = value; }

        //Metodos para a comunicação com o SGDB.
        public bool Conectar()
        {
            string MyConString = "SERVER =" + this.Server + ";DATABASE =" + this.database + ";UID =" + this.uid + ";PASSWORD =" + this.password + ";";
            this.Connection = new MySqlConnection(MyConString);
            this.Connection.Open();
            this.command = this.Connection.CreateCommand();
            return true;
        }

        public bool Desconectar()
        {
            this.Connection.Close();
            return true;
        }

        public MySqlDataReader Consultar(string sql)
        {
            this.Conectar();
            this.command.CommandText = sql; //Atribui o camando sql para a variavel command.
            this.query = command.ExecuteReader(); //Executa o comando no banco e guarda o resultado na variavel query.
            return this.query; //Retorna os resultados para serem usados pelo programa.
        }

        public bool Inserir(string sql)
        {
            this.Conectar();
            this.command.CommandText = sql; //Atribui o camando sql para a variavel command.
            command.ExecuteReader(); //Executa o comando no banco de dados.
            this.Desconectar();
            return true;
        }

        public bool Excluir(string sql)
        {
            try
            {
                this.Conectar();
                this.command.CommandText = sql;
                command.ExecuteReader();
                this.Desconectar();
                return true;
            }catch(MySql.Data.MySqlClient.MySqlException e)
            {
                MessageBox.Show("Esta ação não pode ser executada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
        }

        public bool Atualizar(string sql)
        {
            this.Conectar();
            this.command.CommandText = sql;
            command.ExecuteReader();
            this.Desconectar();
            return true;
        }
    }
}
