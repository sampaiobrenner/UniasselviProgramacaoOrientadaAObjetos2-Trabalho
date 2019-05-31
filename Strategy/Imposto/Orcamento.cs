using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Orcamento
    {
        public Double Valor { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
