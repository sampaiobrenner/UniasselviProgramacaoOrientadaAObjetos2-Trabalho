namespace ChainOfResponsibility
{
    public class DescontoMaisDe500 : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Calcula(orcamento);
        }
    }
}