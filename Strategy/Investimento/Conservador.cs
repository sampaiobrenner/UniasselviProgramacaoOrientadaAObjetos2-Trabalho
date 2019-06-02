namespace Strategy.Investimento
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Conta conta) => (conta.Saldo * 0.008);
    }
}