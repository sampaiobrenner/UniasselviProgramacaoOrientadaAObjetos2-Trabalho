using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TemplateMethod.Relatorio
{
    public abstract class TemplateRelatorio
    {
        public void Imprime(IEnumerable<Conta> contas)
        {
            var str = new StringBuilder()
                .Append(Cabecalho())
                .Append(Corpo(contas))
                .Append(Rodape())
                .ToString();

            MessageBox.Show(str);
        }

        protected abstract string Cabecalho();

        protected abstract string Corpo(IEnumerable<Conta> contas);

        protected abstract string Rodape();
    }
}