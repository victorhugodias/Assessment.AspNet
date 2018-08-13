# Projeto da faculdade Infnet  utilizando Asp.Net para avaliar as competências dos alunos.  
#### Descrição do Projeto.  
  
O aluno deve criar uma aplicação web com o ASP .NET que permita que os funcionários de uma editora gerenciem os livros e os autores dessa editora.
Os livros devem conter os campos id, titulo, ISBN e ano, além da sua lista de autores.
Os autores devem conter os campos id, nome, sobrenome, email e data de nascimento, além da sua lista de livros.
Essa aplicação consiste em:
- Uma página para o cadastro de um livro.
- Uma página para a edição de um livro.
- Uma página de detalhes de um livro.
- Uma página para a deleção de um livro.
- Uma página que exibe a lista de livros.
- Uma página de cadastro de um autor.
- Uma página de edição de um autor.
- Uma página de detalhes de um autor.
- Uma página para a deleção de um autor.
- Uma página que exibe a lista de autores.

É no cadastro de um livro que a relação do livro com os autores é estabelecida. No cadastro de um autor não é atribuído livros a ele.

Essa aplicação web deve permitir que apenas usuários autenticados e autorizados realizem essas operações.

É importante destacar que o aluno deverá criar o banco de dados, as tabelas Livro e Autor, seus relacionamentos, os modelos na aplicação, as visões fortemente tipadas, os controladores e as validações necessárias.

O aluno deve utilizar o Entity Framework e pode escolher o modelo que preferir: Data First, Model First ou Code First.

Essa editora espera poder criar um aplicativo mobile em breve, portanto, é importante que todas essas funcionalidades também estejam disponíveis através de um serviço web API.

Esse serviço consiste em:

- Um método GET para a busca de uma lista de livros.
- Um método GET para a busca de um livro.
- Um método POST para a inclusão de um livro.
- Um método PUT para a atualização de um livro.
- Um método DELETE para a deleção de um livro.
- Um método GET para a busca de uma lista de autores.
- Um método GET para a busca de um autor.
- Um método POST para a criação de um autor.
- Um método PUT para a atualização de um autor.
- Um método DELETE para a deleção de um autor.

O aluno pode utilizar o template de Web API do Visual Studio, pois esse já facilita a parte de Autenticação/Autorização, além de possibilitar o uso do MVC e do Web API em um mesmo projeto.
