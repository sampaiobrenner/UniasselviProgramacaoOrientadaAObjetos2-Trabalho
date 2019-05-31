using System.Collections.Generic;

namespace Decorator.banco
{
    public class FiltroSaldoMaior500k : Filtro
    {
        public FiltroSaldoMaior500k(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroSaldoMaior500k() : base()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                if (conta.Saldo > 500000)
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