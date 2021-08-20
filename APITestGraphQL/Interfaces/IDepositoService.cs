using APITestGraphQL.Models;

namespace APITestGraphQL.Intefaces
{
    public interface IDepositoService
    {
       
        ContaFHT GetConta(int Conta);
        bool Update(ContaFHT conta);
        bool Depositar(int Conta, decimal valor);
    }
}