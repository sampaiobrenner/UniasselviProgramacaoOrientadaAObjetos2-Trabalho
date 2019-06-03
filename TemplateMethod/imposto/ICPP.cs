namespace TemplateMethod.Imposto
{
    public class ICPP : TemplateCondicaoImposto
    {
        protected override bool CondicaoMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}