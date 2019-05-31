using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Desconto()
        {
            Orcamento orcamento = new Orcamento(0);
            orcamento.AdicionaItem(new Item("Caneta", 20));
            orcamento.AdicionaItem(new Item("Lapis", 20));
            orcamento.AdicionaItem(new Item("Boracha", 20));
            orcamento.AdicionaItem(new Item("Liquid Paper", 20));
            orcamento.AdicionaItem(new Item("Xbox", 20));

            CalculadorDeDescontos descontos = new CalculadorDeDescontos();

            var desconto = descontos.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }

        private static void Main(string[] args)
        {
            // Desconto();

            Requisicao();
        }

        private static void Requisicao()
        {
            Conta conta = new Conta("Rodrigo", 590);

            Requisicao req = new Requisicao(Formato.CSV);
            DeterminadorDeResposta responde = new DeterminadorDeResposta();

            responde.executa(req, conta);
            Console.ReadKey();
        }
    }
}