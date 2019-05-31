using System;

namespace Strategy
{
    internal class Arrojado : Investimento
    {
        public double calcula(Conta conta)
        {
            var sorte = new Random().Next(100);

            if (sorte < 20)
            {
                return (conta.Saldo * 0.05);
            }
            else if (sorte < 50)
            {
                return (conta.Saldo * 0.03);
            }
            else
            {
                return (conta.Saldo * 0.006);
            }
        }
    }
}