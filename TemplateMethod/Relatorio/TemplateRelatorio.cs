using System.Collections.Generic;

namespace TemplateMethod.Relatorio
{
    public abstract class TemplateRelatorio
    {
        public abstract void Cabecalho();

        public abstract void Corpo(IList<Conta> contas);

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }

        public abstract void Rodape();
    }
}