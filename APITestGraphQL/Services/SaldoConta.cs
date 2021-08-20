using APITestGraphQL.Database;
using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;
using System.Linq;

namespace APITestGraphQL.Services
{
    public class SaldoConta : ISaldoConta
    {
        private readonly BancoFHTContext _context;

        public int Conta { get; set; }

        public SaldoConta(BancoFHTContext context)
        {
            _context = context;
        }

       

        public ContaFHT GetConta(BuscarConta Conta)
        {
            return _context.Tasks.FirstOrDefault(c => c.Conta == Conta.Conta);
        }
    }
}