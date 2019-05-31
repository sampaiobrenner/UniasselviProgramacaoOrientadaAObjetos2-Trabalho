using System;
using System.Collections.Generic;

namespace Decorator.banco
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
            Console.WriteLine("----------------------------------");
        }

        public override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titutar + " - " + c.Agencia + " - " + c.NumeroDaConta + " - " + c.Saldo + " - " + c.DataDeAbertura.ToString("dd/MM/yyyy"));
            }
        }

        public override void Rodape()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}