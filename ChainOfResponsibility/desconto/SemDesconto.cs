namespace ChainOfResponsibility.Desconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento) => 0;
    }
}