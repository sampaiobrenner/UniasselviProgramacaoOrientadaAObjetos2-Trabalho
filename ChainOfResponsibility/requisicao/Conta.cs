namespace ChainOfResponsibility
{
    public class Conta
    {
        public Conta(string titular, double saldo)
        {
            this.Saldo = saldo;
            this.Titular = titular;
        }

        public double Saldo { get; set; }
        public string Titular { get; set; }
    }
}