namespace TemplateMethod.imposto
{
    public class IHIT : TemplateCondicaoImposto
    {
        public override bool CondicaoMaiorImposto(Orcamento orcamento)
        {
            return Exitem2ItemComMesmoNome(orcamento);
        }

        public override double MaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        private bool Exitem2ItemComMesmoNome(Orcamento orcamento)
        {
            var itensComMesmoNome = 0;
            foreach (var item in orcamento.Itens)
            {
                itensComMesmoNome = 0;
                for (var i = 0; i < orcamento.Itens.Count; i++)
                    if (item.Nome == orcamento.Itens[i].Nome)
                        itensComMesmoNome++;
                if (itensComMesmoNome >= 2) return true;
            }

            return false;
        }
    }
}