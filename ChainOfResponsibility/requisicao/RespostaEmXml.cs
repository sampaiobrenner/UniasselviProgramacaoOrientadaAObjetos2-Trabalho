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
                var xml = new StringBuilder();

                xml.Append("<conta>");
                xml.Append("   <titular>");
                xml.Append("      " + conta.Titular);
                xml.Append("   </titular>");
                xml.Append("   <saldo>");
                xml.Append("      " + conta.Saldo);
                xml.Append("   </saldo>");
                xml.Append("</conta>");

                MessageBox.Show(xml.ToString());
                return;
            }

            Proximo.Responde(requisicao, conta);
        }
    }
}