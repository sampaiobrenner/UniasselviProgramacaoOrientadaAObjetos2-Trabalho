using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.imposto
{
    public abstract class TemplateCondicaoImposto : Imposto
    {
        public TemplateCondicaoImposto(Imposto outroImposto) : base(outroImposto) { }
        public TemplateCondicaoImposto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (CondicaoMaiorImposto(orcamento))
            {
                return MaiorImposto(orcamento) + CalculoDoOutroImposto(orcamento);
            }

            return MenorImposto(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool CondicaoMaiorImposto(Orcamento orcamento);
        public abstract double MaiorImposto(Orcamento orcamento);
        public abstract double MenorImposto(Orcamento orcamento);
        
    }
}
