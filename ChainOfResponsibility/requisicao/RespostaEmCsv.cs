using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class RespostaEmCsv : IResposta
    {
        public IResposta Proximo { get; set; }

        public RespostaEmCsv(IResposta proximo)
        {
            this.Proximo = proximo;
        }
        public RespostaEmCsv()
        {
            this.Proximo = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular+";"+conta.Saldo);
            }
            else
            {
                Proximo.Responde(requisicao, conta);
            }
        }
    }
}
