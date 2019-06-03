using Decorator.Banco;
using Decorator.imposto;
using Decorator.Imposto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Decorator
{
    public static class ExemplosDecorator
    {
        public static void FiltroDeContas()
        {
            var conta1 = new Conta("Rodrigo", 3146, 123456789, 20, new DateTime(1980, 10, 12));
            var conta2 = new Conta("Claudio", 3146, 123456789, 500001, new DateTime(1970, 04, 25));
            var conta3 = new Conta("Agatha", 3146, 123456789, 500, new DateTime(2017, 04, 19));
            var conta4 = new Conta("Helma", 3146, 123456789, 1000, new DateTime(1982, 07, 13));

            var contas = new List<Conta> { conta1, conta2, conta3, conta4 };

            var filtro = new FiltroSaldoMenorQue100(new FiltroSaldoMaior500K(new FiltroContasAbertaNoMesCorrente()));

            var contasFiltradas = filtro.Filtra(contas);

            new RelatorioComplexo().Imprime(contasFiltradas);
        }

        public static void ImpostoComDecorator()
        {
            var orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));

            var imposto = new ImpostoMuitoAlto();
            var imposto2 = new ISS();
            var imposto3 = new ImpostoMuitoAlto(new ISS());

            var retorno = imposto.Calcula(orcamento);
            var retorno2 = imposto2.Calcula(orcamento);
            var retorno3 = imposto3.Calcula(orcamento);

            MessageBox.Show(retorno + " + " + retorno2 + " = " + retorno3);
        }
    }
}