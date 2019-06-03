using System.Collections.Generic;

namespace Decorator.Banco
{
    public class FiltroSaldoMenorQue100 : Filtro
    {
        public FiltroSaldoMenorQue100(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroSaldoMenorQue100()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
                if (conta.Saldo < 100)
                    ContasFiltradas.Add(conta);

            foreach (var conta in Proximo(contas))
                ContasFiltradas.Add(conta);

            return ContasFiltradas;
        }
    }
}