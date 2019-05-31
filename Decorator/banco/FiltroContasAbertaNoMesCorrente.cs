using System;
using System.Collections.Generic;

namespace Decorator.banco
{
    public class FiltroContasAbertaNoMesCorrente : Filtro
    {
        public FiltroContasAbertaNoMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
        }

        public FiltroContasAbertaNoMesCorrente() : base()
        {
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                if (conta.DataDeAbertura.Month == DateTime.Now.Month && conta.DataDeAbertura.Year == DateTime.Now.Year)
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