using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Relatorio
{
    public abstract class TemplateRelatorio
    {
        public abstract void Cabecalho();

        public abstract void Corpo(IList<Conta> contas);

        public abstract void Rodape();

        public void Imprime(IList<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
        
    }
}
