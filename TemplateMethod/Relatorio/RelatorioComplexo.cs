using System;
using System.Collections.Generic;

namespace TemplateMethod.Relatorio
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        public override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titutar + " - " + c.Agencia + " - " + c.NumeroDaConta + " - " + c.Saldo);
            }
        }

        public override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}