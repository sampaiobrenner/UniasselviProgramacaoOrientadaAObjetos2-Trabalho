using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return 0;
        }
    }
}
