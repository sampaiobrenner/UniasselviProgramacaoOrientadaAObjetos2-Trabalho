using System;

namespace Observer.ObserverNotaFiscal
{
    public class EnviadorDeEmail : IAcoesDaNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Nota Fiscal enviada por e-mail");
        }
    }
}