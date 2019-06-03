using System.Collections.Generic;
using TemplateMethod.Imposto;
using TemplateMethod.Relatorio;

namespace TemplateMethod
{
    public static class ExemplosTemplateMethod
    {
        public static void Imposto()
        {
            var orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 20));
            orcamento.AdicionaItem(new Item("Lapis", 20));
            orcamento.AdicionaItem(new Item("Boracha", 20));
            orcamento.AdicionaItem(new Item("Liquid Paper", 20));
            orcamento.AdicionaItem(new Item("Xbox", 420));

            IImposto icpp = new ICPP();
            IImposto ikcv = new IKCV();
            IImposto ihit = new IHIT();

            var calculador = new CalculadorDeImposto();

            calculador.RealizaCalculo(orcamento, ihit);

            orcamento.AdicionaItem(new Item("Caneta", 20));
            calculador.RealizaCalculo(orcamento, ihit);
        }

        public static void Relatorio()
        {
            IList<Conta> contas = new List<Conta>();

            var conta1 = new Conta("Rodrigo", 1234, 789456123, 500);
            var conta2 = new Conta("Claudio", 1234, 456237894, 1500);
            var conta3 = new Conta("Lucia", 3544, 785463214, 700);

            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);

            TemplateRelatorio relatorio1 = new RelatorioSimples();
            TemplateRelatorio relatorio2 = new RelatorioComplexo();

            relatorio1.Imprime(contas);
            relatorio2.Imprime(contas);
        }
    }
}