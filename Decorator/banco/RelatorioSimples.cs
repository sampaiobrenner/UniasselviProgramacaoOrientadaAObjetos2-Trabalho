using System;
using System.Collections.Generic;

namespace Decorator.banco
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("----------------------------------");
        }

        protected override void Corpo(IEnumerable<Conta> contas)
        {
            foreach (var c in contas) Console.WriteLine(c.Titutar + " - " + c.Saldo);
        }

        protected override void Rodape()
        {
            Console.WriteLine("----------------------------------");

            Console.WriteLine("(21) 1234-5678");
            ;
        }
    }
}