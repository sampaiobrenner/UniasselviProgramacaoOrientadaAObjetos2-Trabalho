using System;

namespace ChainOfResponsibility
{
    public class RespostaEmCsv : IResposta
    {
        public RespostaEmCsv(IResposta proximo)
        {
            this.Proximo = proximo;
        }

        public RespostaEmCsv()
        {
            this.Proximo = null;
        }

        public IResposta Proximo { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                Proximo.Responde(requisicao, conta);
            }
        }
    }
}