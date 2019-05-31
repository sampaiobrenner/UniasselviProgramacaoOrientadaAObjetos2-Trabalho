using System;

namespace Decorator.banco
{
    public class Conta
    {
        public Conta(string titular, int agencia, int numerodaconta, double saldo, DateTime dataDeAbertura)
        {
            this.Titutar = titular;
            this.Agencia = agencia;
            this.NumeroDaConta = numerodaconta;
            this.Saldo = saldo;
            this.DataDeAbertura = dataDeAbertura;
        }

        public int Agencia { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }
        public string Titutar { get; set; }
    }
}