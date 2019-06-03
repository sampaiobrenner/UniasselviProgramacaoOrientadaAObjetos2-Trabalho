using Decorator.imposto;

namespace Decorator.Imposto
{
    public class ISS : imposto.Imposto
    {
        public ISS(imposto.Imposto outroImposto) : base(outroImposto)
        {
        }

        public ISS()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}