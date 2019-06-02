namespace Strategy.Imposto
{
    public class Iccc : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05;

            if (orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07;

            return (orcamento.Valor * 0.08) + 30;
        }
    }
}