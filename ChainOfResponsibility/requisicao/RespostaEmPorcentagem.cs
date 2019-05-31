using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class RespostaEmPorcentagem : IResposta
    {
        public IResposta Proximo { get; set; }

        public RespostaEmPorcentagem (IResposta proximo)
        {
            this.Proximo = proximo;
        }
        public RespostaEmPorcentagem()
        {
            this.Proximo = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular+"%"+conta.Saldo);
            }
            else
            {
                Proximo.Responde(requisicao, conta);
            }
        }
    }
}
