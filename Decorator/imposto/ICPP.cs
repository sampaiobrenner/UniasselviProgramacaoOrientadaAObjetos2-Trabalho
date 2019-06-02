namespace Decorator.imposto
{
    public class ICPP : TemplateCondicaoImposto
    {
        public ICPP(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICPP()
        {
        }

        public override bool CondicaoMaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaiorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MenorImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}