using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.banco
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override string Cabecalho()
        {
            return new StringBuilder()
                .Append($"Banco XYZ                             {Environment.NewLine}")
                .Append($"Avenida Paulista, 1234                {Environment.NewLine}")
                .Append($"(11) 1234-5678                        {Environment.NewLine}")
                .Append($"----------------------------------    {Environment.NewLine}")
                .ToString();
        }

        protected override string Corpo(IEnumerable<Conta> contas)
        {
            var str = new StringBuilder();

            foreach (var c in contas)
                str.Append($"{c.Titutar} - {c.Agencia} - {c.NumeroDaConta} - {c.Saldo} - {c.DataDeAbertura:dd/MM/yyyy}  {Environment.NewLine}");

            return str.ToString();
        }

        protected override string Rodape()
        {
            return new StringBuilder()
                .Append($"----------------------------------    {Environment.NewLine}")
                .Append($"banco@xyz.com.br                      {Environment.NewLine}")
                .Append($"{DateTime.Now}                        {Environment.NewLine}")
                .ToString();
        }
    }
}