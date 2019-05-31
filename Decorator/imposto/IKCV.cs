namespace Decorator.imposto
{
    public class IKCV : Imposto
    {
        public IKCV(Imposto outroImposto) : base(outroImposto)
        {
        }

        public IKCV() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500 && TemItemMaiorQue100(orcamento))
            {
                return (orcamento.Valor * 0.1) + CalculoDoOutroImposto(orcamento);
            }

            return (orcamento.Valor * 0.06) + CalculoDoOutroImposto(orcamento);
        }

        private bool TemItemMaiorQue100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}