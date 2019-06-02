using System;
using System.Text;
using System.Windows.Forms;

namespace ChainOfResponsibility.Requisicao
{
    public class RespostaEmXml : IResposta
    {
        public RespostaEmXml(IResposta proximo)
        {
            Proximo = proximo;
        }

        public RespostaEmXml()
        {
            Proximo = null;
        }

        public IResposta Proximo { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.Xml)
            {
                var xml = new StringBuilder()
                    .Append($"<conta>                           {Environment.NewLine}")
                    .Append($"   <titular>                      {Environment.NewLine}")
                    .Append($"         {conta.Titular }         {Environment.NewLine}")
                    .Append($"   </titular>                     {Environment.NewLine}")
                    .Append($"   <saldo>                        {Environment.NewLine}")
                    .Append($"         {conta.Saldo}            {Environment.NewLine}")
                    .Append($"   </saldo>                       {Environment.NewLine}")
                    .Append($"</conta>                          {Environment.NewLine}")
                    .ToString();

                MessageBox.Show(xml);
                return;
            }

            Proximo.Responde(requisicao, conta);
        }
    }
}