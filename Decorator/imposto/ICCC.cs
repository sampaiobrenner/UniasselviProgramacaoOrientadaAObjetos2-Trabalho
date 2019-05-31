namespace Decorator.imposto
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICCC() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return (orcamento.Valor * 0.05) + CalculoDoOutroImposto(orcamento);
            }
            else if (orcamento.Valor <= 3000)
            {
                return (orcamento.Valor * 0.07) + CalculoDoOutroImposto(orcamento);
            }
            else
            {
                return ((orcamento.Valor * 0.08) + 30) + CalculoDoOutroImposto(orcamento);
            }
        }
    }
}