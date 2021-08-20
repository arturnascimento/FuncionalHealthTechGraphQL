using APITestGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace APITestGraphQL.Database
{
    public class BancoFHTContext : DbContext
    {
        public BancoFHTContext(DbContextOptions options) : base(options)
        {            
        }

        public DbSet<ContaFHT> Tasks { get; set; }
    }
}