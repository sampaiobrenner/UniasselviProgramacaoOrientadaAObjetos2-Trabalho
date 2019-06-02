using System.Collections.Generic;

namespace Decorator.banco
{
    public abstract class Filtro
    {
        protected readonly List<Conta> ContasFiltradas;

        protected Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
            ContasFiltradas = new List<Conta>();
        }

        protected Filtro()
        {
            OutroFiltro = null;
            ContasFiltradas = new List<Conta>();
        }

        private Filtro OutroFiltro { get; }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IEnumerable<Conta> Proximo(IList<Conta> contas) => OutroFiltro != null ? OutroFiltro.Filtra(contas) : new List<Conta>();
    }
}