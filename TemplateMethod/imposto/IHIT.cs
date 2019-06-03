namespace TemplateMethod.Imposto
{
    public class IHIT : TemplateCondicaoImposto
    {
        protected override bool CondicaoMaiorImposto(Orcamento orcamento)
        {
            return Exitem2ItemComMesmoNome(orcamento);
        }

        protected override double MaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        private bool Exitem2ItemComMesmoNome(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                var itensComMesmoNome = 0;
                for (var i = 0; i < orcamento.Itens.Count; i++)
                    if (item.Nome == orcamento.Itens[i].Nome)
                        itensComMesmoNome++;
                if (itensComMesmoNome >= 2) return true;
            }

            return false;
        }
    }
}