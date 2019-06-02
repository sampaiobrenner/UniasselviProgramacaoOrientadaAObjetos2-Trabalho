namespace ChainOfResponsibility.Desconto
{
    public class Item
    {
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; }
        public double Valor { get; }
    }
}