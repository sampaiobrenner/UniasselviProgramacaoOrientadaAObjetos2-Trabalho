using System.Collections.Generic;

namespace Decorator.banco
{
    public class FiltroSaldoMenorQue100 : Filtro
    {
        public FiltroSaldoMenorQue100(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroSaldoMenorQue100() : base()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                if (conta.Saldo < 100)
                {
                    ContasFiltradas.Add(conta);
                }
            }
            foreach (Conta conta in Proximo(contas))
            {
                ContasFiltradas.Add(conta);
            }
            return ContasFiltradas;
        }
    }
}