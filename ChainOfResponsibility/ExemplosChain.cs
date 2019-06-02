using ChainOfResponsibility.Desconto;
using ChainOfResponsibility.Requisicao;
using System.Globalization;
using System.Windows.Forms;

namespace ChainOfResponsibility
{
    public static class ExemplosChain
    {
        public static void Desconto()
        {
            var orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 20));
            orcamento.AdicionaItem(new Item("Lapis", 20));
            orcamento.AdicionaItem(new Item("Boracha", 20));
            orcamento.AdicionaItem(new Item("Liquid Paper", 20));
            orcamento.AdicionaItem(new Item("Xbox", 20));

            var desconto = CalculadorDeDescontos.Calcula(orcamento);

            MessageBox.Show(desconto.ToString(CultureInfo.InvariantCulture));
        }

        public static void Requisicao()
        {
            var conta = new Conta("Rodrigo", 590);

            var req = new Requisicao.Requisicao(Formato.Csv);

            DeterminadorDeResposta.Executa(req, conta);
        }
    }
}