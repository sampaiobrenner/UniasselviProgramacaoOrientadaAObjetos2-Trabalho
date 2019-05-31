using System;

namespace State
{
    public class Aprovado : IEstadoDoOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já foi aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O estado já é Aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O estado já foi Aprovado e nao pode ser reprovado!");
        }
    }
}