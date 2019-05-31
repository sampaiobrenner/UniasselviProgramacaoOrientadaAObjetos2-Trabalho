using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Conta
    {
        public double Saldo { get; set; }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
