namespace TemplateMethod.Relatorio
{
    public class Conta
    {
        public Conta(string titular, int agencia, int numerodaconta, double saldo)
        {
            this.Titutar = titular;
            this.Agencia = agencia;
            this.NumeroDaConta = numerodaconta;
            this.Saldo = saldo;
        }

        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }
        public string Titutar { get; set; }
    }
}