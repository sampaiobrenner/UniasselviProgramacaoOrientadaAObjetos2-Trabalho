using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.banco
{
    public class RelatorioSimples : TemplateRelatorio
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("----------------------------------");

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
            Console.WriteLine("----------------------------------");

            Console.WriteLine("(21) 1234-5678"); ;
        }
    }
}
