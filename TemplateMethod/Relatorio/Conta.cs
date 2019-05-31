using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Relatorio
{
    public class Conta
    {
        public string Titutar { get; set; }

        public int Agencia { get; set; }

        public int NumeroDaConta { get; set; }

        public double Saldo { get; set; }

        public Conta(string titular, int agencia, int numerodaconta, double saldo)
        {
            this.Titutar = titular;
            this.Agencia = agencia;
            this.NumeroDaConta = numerodaconta;
            this.Saldo = saldo;

        }
    }
}
