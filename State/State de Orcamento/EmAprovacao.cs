using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class EmAprovacao : IEstadoDoOrcamento
    {
        private bool descontoAplicado = false;

        
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto ja foi aplicado!");
            }
            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O estado Em Aprovacao nao pode ir para finalizado direto!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
