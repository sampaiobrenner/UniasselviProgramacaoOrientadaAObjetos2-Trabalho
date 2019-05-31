using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMais5Itens();
            IDesconto d2 = new DescontoMaisDe500();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Calcula(orcamento);
            
        }
    }
}
