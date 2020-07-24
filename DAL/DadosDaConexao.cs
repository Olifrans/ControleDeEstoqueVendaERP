using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Armazena as informaçoes da minha conexao com o banco de dados
namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get //Devolve os dados de conexao que utilizaremos no projeto
            {
                return "Data Source=DESKTOP-SBPGI7N;Integrated Security=SQLOLEDB.1; Integrated Security = SSPI; Initial Catalog = ControleDeEstoque";
            }
        }
        
    }
}
