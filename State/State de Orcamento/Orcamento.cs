using System.Collections.Generic;

namespace State
{
    public class Orcamento
    {
        public List<Item> Itens = new List<Item>();

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
            EstadoAtual = new EmAprovacao();
        }

        public IEstadoDoOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            this.Valor += item.Valor;
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
    }
}