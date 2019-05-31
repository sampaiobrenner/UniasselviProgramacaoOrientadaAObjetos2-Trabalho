using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.imposto
{
    public class IHIT : TemplateCondicaoImposto
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }
        public IHIT() : base()
        {
        }
        public override bool CondicaoMaiorImposto(Orcamento orcamento)
        {
            return Exitem2ItemComMesmoNome(orcamento);
        }

        private bool Exitem2ItemComMesmoNome(Orcamento orcamento)
        {
            var itensComMesmoNome = 0;
            foreach (var item in orcamento.Itens)
            {
                itensComMesmoNome = 0;
                for (int i = 0; i < orcamento.Itens.Count; i++)
                {
                    if (item.Nome == orcamento.Itens[i].Nome)
                    {
                        itensComMesmoNome++;
                    }
                }
                if (itensComMesmoNome >= 2)
                {
                    return true;
                }
            }
            
            return false;
        }

        public override double MaiorImposto(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100 ;
        }

        public override double MenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor *( 0.01 * orcamento.Itens.Count);
            
        }
    }
}
