using System.Collections.Generic;

namespace Decorator.banco
{
    public abstract class Filtro
    {
        public List<Conta> ContasFiltradas = new List<Conta>();

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            this.OutroFiltro = null;
        }

        public Filtro OutroFiltro { get; set; }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}