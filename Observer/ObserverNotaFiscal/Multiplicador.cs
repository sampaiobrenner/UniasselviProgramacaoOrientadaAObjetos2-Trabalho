using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.ObserverNotaFiscal
{
    public class Multiplicador : IAcoesDaNotaFiscal
    {
        public double Num { get; set; }
        public Multiplicador(double num)
        {
            this.Num = num;
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Num);
        }
    }
}
