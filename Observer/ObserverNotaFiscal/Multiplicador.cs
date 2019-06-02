using System;

namespace Observer.ObserverNotaFiscal
{
    public class Multiplicador : IAcoesDaNotaFiscal
    {
        public Multiplicador(double num)
        {
            Num = num;
        }

        public double Num { get; set; }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * Num);
        }
    }
}