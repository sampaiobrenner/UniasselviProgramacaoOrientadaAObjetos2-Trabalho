using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderNotaFiscal
{
    public class ItemDaNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        

        public ItemDaNotaBuilder ComNome(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome,Valor);            
        }
    }
}
