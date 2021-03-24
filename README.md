# API DOTNET CORE 3
modelo de API REST com .NET core 3
## contexto:
aplicação que tem a função de cadastrar e listar produtos e categorias de uma livraria.
## informações:
* desenvolvido em c#
* api rest exemplo
* depedendencia usado para uso do banco de dados em memória:
  - Microsoft.EntityFrameworkCore.InMemory
* rotas de aplicação:
  - GET (/v1/produts)
  - POST (/v1/produts)
  - GET (/v1/produts/{ID})
  - GET (/v1/category)
* modelos de inserção de dados(product):
 ```
 {
	"title":"book name",
	"description": "description of product",
	"price": 8.0,
	"categoryId": 6
}
 ```
* modelos de inserção de dados(category):
 ```
{
	"title":"title for a catogory ..."
}
 ```
