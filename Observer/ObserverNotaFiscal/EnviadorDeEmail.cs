using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
