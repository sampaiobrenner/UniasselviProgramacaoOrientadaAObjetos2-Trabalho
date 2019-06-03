namespace TemplateMethod.Imposto
{
    public abstract class TemplateCondicaoImposto : IImposto
    {
        public double Calcula(Orcamento orcamento) => CondicaoMaiorImposto(orcamento) ? MaiorImposto(orcamento) : MenorImposto(orcamento);

        protected abstract bool CondicaoMaiorImposto(Orcamento orcamento);

        protected abstract double MaiorImposto(Orcamento orcamento);

        protected abstract double MenorImposto(Orcamento orcamento);
    }
}