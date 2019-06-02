namespace Builder.BuilderNotaFiscal
{
    public class ItemDaNotaBuilder
    {
        private string Nome { get; set; }
        private double Valor { get; set; }

        public ItemDaNota Build()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder WithNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder WithValor(double valor)
        {
            Valor = valor;
            return this;
        }
    }
}