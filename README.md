# ControleDeEstoqueVendaERP
Estudando C#
ERPControleDeEstoque
Aprendendo C# Sistema de Armazenagem

Sistema feito em camadas, com os modelos que representa as tabelas utilizadas

GUI representa a interface gráfica do sistema Controle de Estoque, onde o usuario interagem com o sistema
Esta referenciado com DAL e BLL, ou seja,tudo que estiverem em ambos, pode ser usado por GUI

Modelo contem as class que representam o banco de dados, validada as informações para gravar no BD
Classe ModeloCatergoria representa a tabela Categoria do BD


DAL-Data Axes Lay armazena as class que trabalham com o banco de dados, utilizando as informações passada por meio de um modelo
DAL resposavél pela guarda das informaçoes do cliente no banco de dado 
Esta referenciado com o projeto Modelo, ou seja,tudo que tiver em Modelo pode ser usado e DAL


Classe DadosDaConexao representa a conexão com o BD //Classe DALConexao representa a conexão

Projeto BLL representa as regras de negocios, que valida as informaçoes antes de gravar no banco 
Capta as informações por meio de modelo, validada as informações e grava no banco por meios da camada DAL
Exemplo No GUI tela de cadastro de cliente, o BLL tem a classe que valida as informaçoes do cliente 
Esta referenciado com o projeto DAL e Modelo, ou seja,tudo que tiver em ambos pode ser usado por BLL


Obs: Proximo commit   irei corrigir o erro ao salvar as subcategorias!
