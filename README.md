# Sistema Livraria Blumenau

Backend webapi em C# asp .net core 2 mvc e frontend em Angular

## Características

- O sistema lista todos os livros cadastrador ordenados pelo Título.
- É possível incluir, alterar e excluir livros.
- Backend Web API assincrona com ASP .NET Core MVC.
- Frontend com Angular.
- Persistência com o ORM Entity Framework.
- Separação de responsabilidades, através de serviços com Interface e Dependency Injection.
- Criação automática do banco de dados, migration e seed na primeira inicialização.

## Instruções

- Clonar repositório
https://github.com/cesarliws/livraria-blumenau.git

- Restaurar pacotes
- Build
- Executar o projeto
  - Será criado o banco de dados e populado com 10 registros.

## Stack

- Visual Studio 2017 Community Edition
- .Net Core 2 MVC
- Angular 4: template padrão do Visual Studio para Angular
- Banco de dados MS SqlServer Local


# TODO

- Autenticação e Autorização com JWT
- Gerenciamento de contas de usuário
- Log
- Centralizar captura de excessões
- Testes Unitários
- Menhorar o design do frontend
- Paginação dos registros
- Pesquisas com filtros personalizados
- Criar Entidades e tabelas separadas para
  - Autor
  - Tags
  - Genero
  - Controle de Estoque