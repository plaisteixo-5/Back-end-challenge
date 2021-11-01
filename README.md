# Backend Challenge - Coodesh

Projeto realizado durante o desafio proposto pela Coodesh onde foi implementado uma API CRUD de usuários.

## Tecnologias

Para realizar o projeto foram utilizadas as seguintes bibliotecas e tecnologias:
  1. **Node**
      * Axios: realizar requisições
      * Debug: debugar o sistema
      * Dotenv: comunicar as variáveis de ambiente com o sistema
      * Express: framework para criar a API
      * Http: criar o servidor
      * Mongoose: criar o modelo e realizar as transações no banco
      * Node Cron: realizar as atualizações no banco de minuto em minuto
      * Nodemon: realizar o hot realod na aplicação
  2. **Docker**
  3. **MongoDB**
  4. [**Random User API**](https://randomuser.me/)

## Rodando a aplicação

Para rodar a aplicação é necessário ter o docker e o docker compose instalados na sua máquina e o git.
Clone o projeto:

```bash
git clone https://github.com/plaisteixo-5/Back-end-challenge
```
Entre na pasta PharmaInc

```zsh
cd Back-end-challenge/PharmaInc/
```

Crie a imagem da API

```zsh
sudo docker build -t backend-challenge .
```

Suba a imagem e o banco
```zsh
make up
```
O comando acima na verdade roda o comando ```sudo docker-compose up -d```.

Agora, utilizando postman ou outra ferramenta é possível realizar requisições no sistema. A api roda por padrão na porta 3000 e o mongo na porta 27017.
A cada um minuto o sistema automaticamente realiza uma requisição na api [Random User](https://randomuser.me/api/).

### Endpoints
  - `GET /`: Retorna a mensagem "REST Back-end Challenge 20201209 Running"
  - `GET /users/:userId`: Retorna os dados de um usuário específico
  - `GET /users`: Listar todos os usuários da base de dados
  - `PUT /users/v1/`: Endpoint que o sistema utiliza para realizar as atualizações de minuto em minuto
  - `PUT /users/`: Insere um usuário na base de dados
  - `DELETE /users/:userId`: Remove o usuário da base de dados

Para parar a aplicação utilize ```make down``` e para ver os logs utilize ```make logs```.


> Desenvolvidor por: Felipe "Fon"
> 
> challenge by coodesh
