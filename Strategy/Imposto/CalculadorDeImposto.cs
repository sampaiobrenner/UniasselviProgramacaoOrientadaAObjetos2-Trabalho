using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
        
    }
}
