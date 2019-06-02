namespace Decorator.imposto
{
    public abstract class TemplateCondicaoImposto : Imposto
    {
        public TemplateCondicaoImposto(Imposto outroImposto) : base(outroImposto)
        {
        }

        public TemplateCondicaoImposto()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (CondicaoMaiorImposto(orcamento)) return MaiorImposto(orcamento) + CalculoDoOutroImposto(orcamento);

            return MenorImposto(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool CondicaoMaiorImposto(Orcamento orcamento);

        public abstract double MaiorImposto(Orcamento orcamento);

        public abstract double MenorImposto(Orcamento orcamento);
    }
}