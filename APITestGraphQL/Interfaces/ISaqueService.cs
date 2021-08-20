using APITestGraphQL.Models;

namespace APITestGraphQL.Intefaces
{
    public interface ISaqueService
    {
        ContaFHT GetConta(int Conta);
        bool Update(ContaFHT conta);
        bool Sacar(int Conta, decimal valor);
    }
}