using System;
using System.Collections.Generic;

namespace Decorator.Banco
{
    public class FiltroContasAbertaNoMesCorrente : Filtro
    {
        public FiltroContasAbertaNoMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroContasAbertaNoMesCorrente()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
                if (conta.DataDeAbertura.Month == DateTime.Now.Month && conta.DataDeAbertura.Year == DateTime.Now.Year)
                    ContasFiltradas.Add(conta);
            foreach (var conta in Proximo(contas)) ContasFiltradas.Add(conta);
            return ContasFiltradas;
        }
    }
}