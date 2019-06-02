using System.Windows.Forms;

namespace ChainOfResponsibility.Requisicao
{
    public class RespostaEmCsv : IResposta
    {
        public RespostaEmCsv(IResposta proximo)
        {
            Proximo = proximo;
        }

        public RespostaEmCsv()
        {
            Proximo = null;
        }

        public IResposta Proximo { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.Csv)
            {
                MessageBox.Show($"{conta.Titular};{conta.Saldo}");
                return;
            }

            Proximo.Responde(requisicao, conta);
        }
    }
}