using System.Collections.Generic;

namespace ChainOfResponsibility.Desconto
{
    public class Orcamento
    {
        public readonly List<Item> Itens;

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public double Valor { get; private set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }
    }
}