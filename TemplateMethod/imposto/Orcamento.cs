using System.Collections.Generic;

namespace TemplateMethod
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
            this.Valor += item.Valor;
        }
    }
}