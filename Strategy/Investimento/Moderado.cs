using System;

namespace Strategy
{
    internal class Moderado : Investimento
    {
        public double calcula(Conta conta)
        {
            var sorte = new Random().Next(100) > 49;

            if (sorte)
            {
                return (conta.Saldo * 0.025);
            }
            else
            {
                return (conta.Saldo * 0.007);
            }
        }
    }
}