using System;

namespace Observer.ObserverNotaFiscal
{
    public class NotaFiscalDao : IAcoesDaNotaFiscal
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Nota Fiscal foi adicionada ao banco de dados com sucesso!");
        }
    }
}