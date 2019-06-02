using System;
using State.State_de_Conta;
using State.State_de_Orcamento;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // StateDeOrcamento();

            StateDeConta();
        }

        private static void StateDeConta()
        {
            var conta = new Conta(500);

            Console.WriteLine(conta.Saldo);
            conta.Saca(600);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(200);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(100);
            Console.WriteLine(conta.Saldo);

            Console.ReadKey();
        }

        private static void StateDeOrcamento()
        {
            var reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();

            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();

            Console.ReadKey();
        }
    }
}