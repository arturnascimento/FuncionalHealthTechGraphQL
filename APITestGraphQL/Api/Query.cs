using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;
using HotChocolate;

namespace APITestGraphQL.Api
{
    public class Query
    {
   
        public decimal Saldo([Service] ISaldoConta saldoConta, BuscarConta conta )
        {
            return saldoConta.GetConta(conta).Saldo;
        }
    }
}