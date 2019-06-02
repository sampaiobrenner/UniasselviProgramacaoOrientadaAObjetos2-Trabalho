namespace ChainOfResponsibility.Desconto
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (VendaCasada(orcamento))
                return orcamento.Valor * 0.05;

            return Proximo.Calcula(orcamento);
        }

        private bool VendaCasada(Orcamento orcamento)
        {
            var contem = 0;
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome == "Lapis" || item.Nome == "Caneta") contem++;
            }

            return contem == 2;
        }
    }
}