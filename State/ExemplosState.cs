using System;

namespace State
{
    public static class ExemplosState
    {
        public static void StateDeConta()
        {
            var conta = new Conta.Conta(500);

            Console.WriteLine(conta.Saldo);
            conta.Saca(600);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(200);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(100);
            Console.WriteLine(conta.Saldo);
        }

        public static void StateDeOrcamento()
        {
            var reforma = new Orcamento.Orcamento(500);

            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();

            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
        }
    }
}