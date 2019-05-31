using System;

namespace Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Calcula(Conta conta, Investimento investimento)
        {
            var valor = investimento.calcula(conta);
            conta.Saldo += valor * 0.75;
            Console.WriteLine(conta.Saldo);
        }
    }
}