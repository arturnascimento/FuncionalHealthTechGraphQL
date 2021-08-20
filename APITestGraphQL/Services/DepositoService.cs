using System.Linq;
using APITestGraphQL.Database;
using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;

namespace APITestGraphQL.Services
{
    public class DepositoService : IDepositoService
    {
        private readonly BancoFHTContext _context;
        

        public DepositoService(BancoFHTContext context)
        {
            _context = context;
            
        }

        public bool Depositar(int Conta, decimal valor)
        {
            try
            {
                var ContaDeposito = GetConta(Conta);
                ContaDeposito.Saldo += valor;

                _context.Tasks.Update(ContaDeposito);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ContaFHT GetConta(int Conta)
        {
            return _context.Tasks.FirstOrDefault(c => c.Conta == Conta);
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