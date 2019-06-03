namespace TemplateMethod.Imposto
{
    public abstract class TemplateCondicaoImposto : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (CondicaoMaiorImposto(orcamento)) return MaiorImposto(orcamento);

            return MenorImposto(orcamento);
        }

        public abstract bool CondicaoMaiorImposto(Orcamento orcamento);

        public abstract double MaiorImposto(Orcamento orcamento);

        public abstract double MenorImposto(Orcamento orcamento);
    }
}