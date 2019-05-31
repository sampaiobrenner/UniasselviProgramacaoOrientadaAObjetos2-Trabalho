using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string Titular { get; set; }

        public Conta(string titular, double saldo)
        {
            this.Saldo = saldo;
            this.Titular = titular;
        }
    }
    
}
