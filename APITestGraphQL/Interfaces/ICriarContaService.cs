using APITestGraphQL.Models;

namespace APITestGraphQL.Intefaces
{
    public interface ICriarContaService
    {
        bool Create(ContaFHT conta);
        ContaFHT GetConta(int Conta);
    }
}