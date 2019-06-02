namespace ChainOfResponsibility.Requisicao
{
    public class Conta
    {
        public Conta(string titular, double saldo)
        {
            Saldo = saldo;
            Titular = titular;
        }

        public double Saldo { get; }
        public string Titular { get; }
    }
}