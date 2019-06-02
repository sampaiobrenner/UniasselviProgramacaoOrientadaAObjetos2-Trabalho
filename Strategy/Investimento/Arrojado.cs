using System;

namespace Strategy.Investimento
{
    internal class Arrojado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            var sorte = new Random().Next(100);

            if (sorte < 20)
                return (conta.Saldo * 0.05);

            if (sorte < 50)
                return (conta.Saldo * 0.03);

            return (conta.Saldo * 0.006);
        }
    }
}