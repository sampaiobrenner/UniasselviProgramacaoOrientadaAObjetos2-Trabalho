using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens = new List<Item>();

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            this.Valor += item.Valor;
        }
        
    }
}
