using System.Collections.Generic;

namespace Decorator.imposto
{
    public class Orcamento
    {
        public List<Item> Itens = new List<Item>();

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
        }

        public double Valor { get; private set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }
    }
}