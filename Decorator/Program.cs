using System;
using System.Collections.Generic;
using Decorator.banco;
using Decorator.imposto;

namespace Decorator
{
    internal class Program
    {
        private static void FiltroDeContas()
        {
            var conta1 = new Conta("Rodrigo", 3146, 123456789, 20, new DateTime(1980, 10, 12));
            var conta2 = new Conta("Claudio", 3146, 123456789, 500001, new DateTime(1970, 04, 25));
            var conta3 = new Conta("Agatha", 3146, 123456789, 500, new DateTime(2017, 04, 19));
            var conta4 = new Conta("Helma", 3146, 123456789, 1000, new DateTime(1982, 07, 13));
            var contas = new List<Conta>();
            contas.Add(conta1);
            contas.Add(conta2);
            contas.Add(conta3);
            contas.Add(conta4);
            Filtro filtro = new FiltroSaldoMenorQue100(new FiltroSaldoMaior500k(new FiltroContasAbertaNoMesCorrente()));
            var contasFiltradas = filtro.Filtra(contas);

            var relatorio = new RelatorioComplexo();
            relatorio.Imprime(contasFiltradas);

            Console.ReadKey();
        }

        private static void ImpostoComDecorator()
        {
            var orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));

            Imposto Imposto = new ImpostoMuitoAlto();
            Imposto Imposto2 = new ISS();
            Imposto Imposto3 = new ImpostoMuitoAlto(new ISS());

            var retorno = Imposto.Calcula(orcamento);
            var retorno2 = Imposto2.Calcula(orcamento);
            var retorno3 = Imposto3.Calcula(orcamento);

            Console.WriteLine(retorno + " + " + retorno2 + " = " + retorno3);
            Console.ReadKey();
        }

        private static void Main(string[] args)
        {
            //ImpostoComDecorator();

            FiltroDeContas();
        }
    }
}