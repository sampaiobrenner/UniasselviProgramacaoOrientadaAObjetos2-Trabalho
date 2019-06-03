using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Relatorio
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho()
        {
            return new StringBuilder()
                .Append($"Banco XYZ                             {Environment.NewLine}")
                .Append($"----------------------------------    {Environment.NewLine}")
                .ToString();
        }

        protected override string Corpo(IEnumerable<Conta> contas)
        {
            var str = new StringBuilder();

            foreach (var c in contas)
                str.Append($"{c.Titutar} - {c.Saldo}            {Environment.NewLine}");

            return str.ToString();
        }

        protected override string Rodape()
        {
            return new StringBuilder()
                .Append($"----------------------------------    {Environment.NewLine}")
                .Append($"(21) 1234-5678                        {Environment.NewLine}")
                .ToString();
        }
    }
}