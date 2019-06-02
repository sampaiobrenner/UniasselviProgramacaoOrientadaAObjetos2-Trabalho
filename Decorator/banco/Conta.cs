using System;

namespace Decorator.banco
{
    public class Conta
    {
        public Conta(string titular, int agencia, int numerodaconta, double saldo, DateTime dataDeAbertura)
        {
            Titutar = titular;
            Agencia = agencia;
            NumeroDaConta = numerodaconta;
            Saldo = saldo;
            DataDeAbertura = dataDeAbertura;
        }

        public int Agencia { get; }
        public DateTime DataDeAbertura { get; }
        public int NumeroDaConta { get; }
        public double Saldo { get; }
        public string Titutar { get; }
    }
}