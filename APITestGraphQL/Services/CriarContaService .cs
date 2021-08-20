using System;
using System.Linq;
using APITestGraphQL.Database;
using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;

namespace APITestGraphQL.Services
{
    public class CriarContaService : ICriarContaService
    {
        private readonly BancoFHTContext _context;

        public CriarContaService(BancoFHTContext context)
        {
            _context = context;
        }


        public bool Create(ContaFHT Conta)
        {
            try
            {
                var exists = GetConta(Conta.Conta);
                if (exists != null) return false;
                _context.Tasks.Add(Conta);
                _context.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }

        public ContaFHT GetConta(int Conta)
        {
            return _context.Tasks.FirstOrDefault(c => c.Conta == Conta);
        }
    }
}