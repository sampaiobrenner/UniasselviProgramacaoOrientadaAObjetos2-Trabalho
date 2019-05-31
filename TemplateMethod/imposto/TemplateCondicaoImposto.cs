using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class TemplateCondicaoImposto : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (CondicaoMaiorImposto(orcamento))
            {
                return MaiorImposto(orcamento);
            }

            return MenorImposto(orcamento);
        }

        public abstract bool CondicaoMaiorImposto(Orcamento orcamento);
        public abstract double MaiorImposto(Orcamento orcamento);
        public abstract double MenorImposto(Orcamento orcamento);
        
    }
}
