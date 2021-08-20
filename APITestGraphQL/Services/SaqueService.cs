using System.Linq;
using APITestGraphQL.Database;
using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;

namespace APITestGraphQL.Services
{
    public class SaqueService : ISaqueService
    {
        private readonly BancoFHTContext _context;

        public SaqueService(BancoFHTContext context)
        {
            _context = context;
        }

        public ContaFHT GetConta(int Conta)
        {
            return _context.Tasks.FirstOrDefault(c => c.Conta == Conta);
        }

        public bool Sacar(int Conta, decimal valor)
        {
            try
            {
                var ContaSaque = GetConta(Conta);
                if (ContaSaque.Saldo < valor) return false;
                ContaSaque.Saldo -= valor;
                _context.Tasks.Update(ContaSaque);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(ContaFHT conta)
        {
            try
            {
                var exists = GetConta(conta.Conta);
                if (exists == null) return false;
                exists.Saldo = conta.Saldo;
                _context.Tasks.Update(exists);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
      
