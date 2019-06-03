using System.Windows.Forms;

namespace Observer.ObserverNotaFiscal
{
    public class EnviadorDeEmail : IAcoesDaNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            MessageBox.Show("Nota Fiscal enviada por e-mail.");
        }
    }
}