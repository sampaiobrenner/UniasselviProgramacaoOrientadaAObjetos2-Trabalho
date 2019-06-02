namespace Decorator.imposto
{
    public abstract class Imposto
    {
        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public Imposto OutroImposto { get; set; }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;

            return OutroImposto.Calcula(orcamento);
        }
    }
}