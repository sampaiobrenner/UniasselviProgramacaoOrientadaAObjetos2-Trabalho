namespace Builder.BuilderNotaFiscal
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; }
        public double Valor { get; }
    }
}