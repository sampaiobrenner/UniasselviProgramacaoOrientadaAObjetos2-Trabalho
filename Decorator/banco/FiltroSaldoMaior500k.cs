using System.Collections.Generic;

namespace Decorator.Banco
{
    public class FiltroSaldoMaior500K : Filtro
    {
        public FiltroSaldoMaior500K(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroSaldoMaior500K()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
                if (conta.Saldo > 500000)
                    ContasFiltradas.Add(conta);

            foreach (var conta in Proximo(contas))
                ContasFiltradas.Add(conta);

            return ContasFiltradas;
        }
    }
}