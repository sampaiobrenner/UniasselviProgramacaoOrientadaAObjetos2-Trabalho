using Strategy.Imposto;
using Strategy.Investimento;

namespace Strategy
{
    public static class ExemplosStrategy
    {
        public static void Imposto()
        {
            var iss = new Iss();
            var icms = new Icms();
            var iccc = new Iccc();

            var orcamento = new Orcamento(4000);

            CalculadorDeImposto.RealizaCalculo(orcamento, iss);
            CalculadorDeImposto.RealizaCalculo(orcamento, icms);
            CalculadorDeImposto.RealizaCalculo(orcamento, iccc);
        }

        public static void Investimento()
        {
            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            var conta = new Conta(100);

            RealizadorDeInvestimentos.Calcula(conta, arrojado);
        }
    }
}