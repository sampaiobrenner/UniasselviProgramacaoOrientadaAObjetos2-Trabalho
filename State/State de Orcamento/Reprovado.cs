using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Reprovado : IEstadoDoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Estado reprovado não recebe desconto!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O estado já é Reprovado e nao pode mais ser aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O estado já foi Rprovado!");
        }
    }
}
