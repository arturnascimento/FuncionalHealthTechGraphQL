using APITestGraphQL.Models;

namespace APITestGraphQL.Intefaces
{
    public interface ISaldoConta
    {
        ContaFHT GetConta(BuscarConta conta);
    }
}