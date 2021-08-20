using System;
using System.ComponentModel.DataAnnotations;

namespace APITestGraphQL.Models
{
    public class ContaFHT
    {
        [Key]
        public Guid? Id { get; set; }
        public int Conta { get; set; }
        public decimal Saldo { get; set; }
        public string Erro { get; set; }
    }
}