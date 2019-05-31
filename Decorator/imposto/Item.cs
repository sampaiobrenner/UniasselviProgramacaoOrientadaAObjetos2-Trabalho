namespace Decorator.imposto
{
    public class Item
    {
        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}