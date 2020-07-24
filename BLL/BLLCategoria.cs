using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tratar das regras de negócio da tabela categoria, responsavel por integir com a interfe
namespace BLL
{
    public class BLLCategoria
    {       
        private DALConexao conexao;
        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo) //Metodo incluir -- insere uma categoria no BD
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper(); //Coverte para maiusculo o conteudo da propriedade

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo) //Metodo alterar -- altera dados no BD
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper(); //Coverte para maiusculo o conteudo da propriedade

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}

