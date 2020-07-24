using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Representa nossa conexão
namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao; //Armazena a string de conexão
        private SqlConnection _conexao; //Conexão SQL


        public DALConexao(String dadosConexao) //Construtor que rece uma tring de conexao
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao //Pegar o valor do obejeto _conexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()//Metodo conectar
        {
            this._conexao.Open();
        }

        public void Desconectar()//Metodo desconectar
        {
            this._conexao.Close();
        }

    }
}
