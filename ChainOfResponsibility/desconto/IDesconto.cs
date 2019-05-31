using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double Calcula(Orcamento orcamento);
    }
}
