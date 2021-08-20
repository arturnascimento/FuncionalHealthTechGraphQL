# FuncionalHealthTechGraphQL

Minha primeira API em GraphQL

Exame de Programador C#
Objetivo
Desenvolver uma API em C# com .NET Core que simule algumas funcionalidades de um banco digital. Nesta simulação considere que não há necessidade de autenticação.

Desafio
Você deverá garantir que o usuário conseguirá realizar uma movimentação de sua conta corrente para quitar uma dívida.

Cenários
DADO QUE eu consuma a API
QUANDO eu chamar a mutation sacar informando o número da conta e um valor válido
ENTÃO o saldo da minha conta no banco de dados diminuirá de acordo
E a mutation retornará o saldo atualizado.
![Saque](https://user-images.githubusercontent.com/69171098/130162995-319a5b8c-cba9-4106-bd35-5b64138a5e74.jpg)

DADO QUE eu consuma a API
QUANDO eu chamar a mutation sacar informando o número da conta e um valor maior do que o meu saldo
ENTÃO a mutation me retornará um erro do GraphQL informando que eu não tenho saldo suficiente
![SaqueSaldoInsuficiente](https://user-images.githubusercontent.com/69171098/130163024-9f5c733a-9deb-4ba7-9c8d-9ae956c654ee.jpg)

DADO QUE eu consuma a API
QUANDO eu chamar a mutation depositar informando o número da conta e um valor válido
ENTÃO a mutation atualizará o saldo da conta no banco de dados
E a mutation retornará o saldo atualizado.
![Deposito](https://user-images.githubusercontent.com/69171098/130163051-819f6303-4e46-4502-ac87-1af17a164c44.jpg)


DADO QUE eu consuma a API
QUANDO eu chamar a query saldo informando o número da conta
ENTÃO a query retornará o saldo atualizado.
![Saldo](https://user-images.githubusercontent.com/69171098/130163061-a828ec4c-a0fe-4c31-b03f-1f22ba8289c5.jpg)

É possível criar uma nova conta também.
![CriarConta](https://user-images.githubusercontent.com/69171098/130163386-c0e7b23b-0f95-4b88-9552-85c37b6d9adc.jpg)



Foram utilizados no projeto:
- .Net Core 3.1
- SqlServer
- ORM EntityFramework
- HotChocolate
- HotCholatePlayground
