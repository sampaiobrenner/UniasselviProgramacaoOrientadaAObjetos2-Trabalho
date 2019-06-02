namespace Strategy.Imposto
{
    public class Iss : IImposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
    }
}