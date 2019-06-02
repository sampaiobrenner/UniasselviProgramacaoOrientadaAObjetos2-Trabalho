using System.Collections.Generic;

namespace Decorator.banco
{
    public abstract class TemplateRelatorio
    {
        public void Imprime(IEnumerable<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }

        protected abstract void Cabecalho();

        protected abstract void Corpo(IEnumerable<Conta> contas);

        protected abstract void Rodape();
    }
}