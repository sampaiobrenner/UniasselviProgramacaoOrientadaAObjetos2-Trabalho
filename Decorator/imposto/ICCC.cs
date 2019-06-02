namespace Decorator.imposto
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ICCC()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
            if (orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
            return orcamento.Valor * 0.08 + 30 + CalculoDoOutroImposto(orcamento);
        }
    }
}