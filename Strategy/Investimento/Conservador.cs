namespace Strategy
{
    public class Conservador : Investimento
    {
        public double calcula(Conta conta)
        {
            return (conta.Saldo * 0.008);
        }
    }
}