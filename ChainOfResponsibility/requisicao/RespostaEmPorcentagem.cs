using System.Windows.Forms;

namespace ChainOfResponsibility.Requisicao
{
    public class RespostaEmPorcentagem : IResposta
    {
        public RespostaEmPorcentagem(IResposta proximo)
        {
            Proximo = proximo;
        }

        public RespostaEmPorcentagem()
        {
            Proximo = null;
        }

        public IResposta Proximo { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.Porcento)
            {
                MessageBox.Show(conta.Titular + "%" + conta.Saldo);
                return;
            }

            Proximo.Responde(requisicao, conta);
        }
    }
}