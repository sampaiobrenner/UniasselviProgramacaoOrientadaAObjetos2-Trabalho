namespace State.Conta
{
    public class Conta
    {
        public Conta(double saldo)
        {
            Saldo = saldo;
            if (saldo < 0)
                EstadoDaConta = new Negativo();
            else
                EstadoDaConta = new Positivo();
        }

        public IEstadoDeConta EstadoDaConta { private get; set; }

        public double Saldo { get; set; }

        public void Deposita(double valor)
        {
            EstadoDaConta.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            EstadoDaConta.Saca(this, valor);
        }
    }
}