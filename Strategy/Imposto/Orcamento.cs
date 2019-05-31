using System;

namespace Strategy
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }

        public Double Valor { get; private set; }
    }
}