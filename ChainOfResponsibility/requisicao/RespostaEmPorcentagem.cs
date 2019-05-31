using System;

namespace ChainOfResponsibility
{
    public class RespostaEmPorcentagem : IResposta
    {
        public RespostaEmPorcentagem(IResposta proximo)
        {
            this.Proximo = proximo;
        }

        public RespostaEmPorcentagem()
        {
            this.Proximo = null;
        }

        public IResposta Proximo { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                Proximo.Responde(requisicao, conta);
            }
        }
    }
}