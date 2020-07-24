using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class que representa a tabela categoria catcode e catnome no banco de dados
namespace Modelo
{
    public class ModeloCategoria
    {
        //Construtor sem parametro - ele é chamado todo vez que estaciamos oum objeto - e possue o mesmo nome da classe
        public ModeloCategoria()
        {
            //Iniciand as propriedades
            this.CatCod = 0;
            this.CatNome = "";
        }

        //Construtor com parametro - ele é chamado todo vez que estaciamos oum objeto - e possue o mesmo nome da classe
        public ModeloCategoria(int catcod, String nome)
        {
            //Iniciand as propriedades
            this.CatCod = catcod;
            this.CatNome = nome;
        }







        private int cat_cod;
            public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        private String cat_nome;
        public String CatNome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }

        }
    }
}
