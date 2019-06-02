namespace Strategy.Imposto
{
    public class Icms : IImposto
    {
        public double Calcula(Orcamento orcamento) => (orcamento.Valor * 0.05) + 50;
    }
}