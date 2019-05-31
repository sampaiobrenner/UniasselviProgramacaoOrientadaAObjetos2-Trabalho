namespace Observer.ObserverNotaFiscal
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public string Nome { get; private set; }
        public double Valor { get; private set; }
    }
}