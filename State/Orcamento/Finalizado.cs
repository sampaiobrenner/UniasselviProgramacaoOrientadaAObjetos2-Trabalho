using System;

namespace State.Orcamento
{
    public class Finalizado : IEstadoDoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Estado finalizado não recebe desconto!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O estado já foi finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O estado já foi finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O estado já foi finalizado!");
        }
    }
}