using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almoxarifado01
{
    class Movimentacao
    {
        //Atributos da classe
        private int idMovimentacao;
        private int idProduto; //atributo referencia (Produto)
        private int idPrateleira; //atributo referencia (Prateleira)
        private int idUsuario; //atributo referencia (Usuario);
        private int idSolicitante; //atributo referencia (Solicitante)
        private string momento;
        private string validade;
        private int quantidade;
        private string preco;
        
        //Metodos get e set
        public int IdMovimentacao { get => idMovimentacao; set => idMovimentacao = value; }
        public string Validade { get => validade; set => validade = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Preco { get => preco; set => preco = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdPrateleira { get => idPrateleira; set => idPrateleira = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdSolicitante { get => idSolicitante; set => idSolicitante = value; }

        public void CadastrarMovimentacao(string tipoMovimentacao)
        {
            BancoDados bancoDados = new BancoDados();
            MySqlDataReader query = bancoDados.Consultar("select now();");

            while (query.Read())
            {
                this.momento = query.GetString("now()");
            }

            string[] momento = this.momento.Split(' '); // momento[0] = 22/11/2017, momento[1] = 20:40:01
            string[] data = momento[0].Split('/'); // data[0] = 22, data[1] = 11, data[2] = 2017
            this.momento = data[2] + "-" + data[1] + "-" + data[0] + " " + momento[1]; // 2017-11-22 20:40:01

            bancoDados.Inserir("insert into movimentacao (Produto_idProduto, Prateleira_idPrateleira, Usuario_idUsuario, Solicitante_idSolicitante, " +
                "momento, validade, quantidade, preco, tipo) values("+ this.idProduto +","+ this.idPrateleira +","+ this.idUsuario +","+ this.idSolicitante +
                ",'"+ this.momento +"','"+ this.validade +"',"+ this.quantidade +",'"+ this.preco +"','"+ tipoMovimentacao +"');");
        }
    }
}
