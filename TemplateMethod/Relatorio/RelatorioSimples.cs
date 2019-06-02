using System;
using System.Collections.Generic;

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
            foreach (var c in contas) Console.WriteLine(c.Titutar + " - " + c.Saldo);
        }

        public override void Rodape()
        {
            Console.WriteLine("(21) 1234-5678");
            ;
        }
    }
}