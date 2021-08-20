using APITestGraphQL.Intefaces;
using APITestGraphQL.Models;
using HotChocolate;

namespace APITestGraphQL.Api
{
    public class Mutation
    {
        
        public ContaFHT deposito([Service] IDepositoService depositoService, MovimentacaoConta movimentacao)
        {
            if (movimentacao.valor <= 0)
            {
                depositoService.GetConta(movimentacao.Conta).Erro = "Valor para depósito inválido. Tente valores maiores do que 0.00";
                return depositoService.GetConta(movimentacao.Conta);
            }
            depositoService.GetConta(movimentacao.Conta).Erro = "";
            depositoService.Depositar(movimentacao.Conta, movimentacao.valor);
            return depositoService.GetConta(movimentacao.Conta);
        }

        public ContaFHT sacar([Service]ISaqueService saqueService, MovimentacaoConta movimentacao)
        {
            if (movimentacao.valor > saqueService.GetConta(movimentacao.Conta).Saldo)
            {
                saqueService.GetConta(movimentacao.Conta).Erro = "Saldo insuficiente!";
                return saqueService.GetConta(movimentacao.Conta);
            }
            saqueService.GetConta(movimentacao.Conta).Erro = "";
            saqueService.Sacar(movimentacao.Conta, movimentacao.valor);
            return saqueService.GetConta(movimentacao.Conta);
        }

        public ContaFHT criar([Service] ICriarContaService criarContaService, ContaFHT conta)
        {
            criarContaService.Create(conta);
            return criarContaService.GetConta(conta.Conta);
        }

    }
}