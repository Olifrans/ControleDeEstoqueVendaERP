# ControleDeEstoqueVendaERP 
Estudando C# Com Um Sistema de Armazenagem

Sistema contruido em camadas, com os modelos que representam as tabelas utilizadas

GUI representa a interface gráfica do sistema, onde o usuario interagem com o sistema
Esta referenciado com DAL e BLL, ou seja,tudo que estiverem em ambos, pode ser usado por GUI

Modelo contém as class que representam o BD e valida as informações para gravar no BD

DAL-Data Axes Lay armazena as class que trabalham com o BD, utilizando as informações passada por meio de um Modelo
É resposavél pela guarda das informaçoes do cliente no BD
Esta referenciado com o projeto Modelo, ou seja,tudo que tiver em Modelo pode ser usado e DAL


Projeto BLL representa as regras de negócios, que valida as informaçoes antes de gravar BD
Capta as informações por meio de um modeloV
Valida as informações e grava no BD por meios da camada DAL
Esta referenciado com o projeto DAL e Modelo, ou seja,tudo que estiverem em ambos pode ser usado por BLL


Obs: No proximo commit, irei corrigir o erro que esta impedindo de salvar as subcategorias no BD!
