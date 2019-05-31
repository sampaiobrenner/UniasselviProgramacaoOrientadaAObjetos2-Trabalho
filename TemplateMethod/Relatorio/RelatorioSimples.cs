using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Relatorio
{
    public class RelatorioSimples : TemplateRelatorio
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        public override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titutar + " - " + c.Saldo);
            }
        }

        public override void Rodape()
        {
            Console.WriteLine("(21) 1234-5678"); ;
        }
    }
}
