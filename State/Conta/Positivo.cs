namespace State.Conta
{
    public class Positivo : IEstadoDeConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += (valor * 0.98);
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0)
            {
                conta.EstadoDaConta = new Negativo();
            }
        }
    }
}