using System;

namespace Strategy.Investimento
{
    internal class Moderado : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            var sorte = new Random().Next(100) > 49;

            if (sorte)
                return (conta.Saldo * 0.025);

            return (conta.Saldo * 0.007);
        }
    }
}