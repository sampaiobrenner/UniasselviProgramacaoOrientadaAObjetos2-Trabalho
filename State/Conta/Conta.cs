using System;

namespace State.Conta
{
    public class Conta
    {
        public Conta(double saldo)
        {
            Saldo = saldo;
            if (saldo < 0)
                EstadoDaConta = new Negativo();
            else
                EstadoDaConta = new Positivo();
        }

        public IEstadoDeConta EstadoDaConta { get; set; }

        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            EstadoDaConta.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            EstadoDaConta.Saca(this, valor);
        }

        public interface IEstadoDeConta
        {
            void Deposita(Conta conta, double valor);

            void Saca(Conta conta, double valor);
        }

        public class Negativo : IEstadoDeConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo >= 0) conta.EstadoDaConta = new Positivo();
            }

            public void Saca(Conta conta, double valor)
            {
                throw new Exception("Contas negativas não podem efetuar saques");
            }
        }

        public class Positivo : IEstadoDeConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Saca(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                if (conta.Saldo < 0) conta.EstadoDaConta = new Negativo();
            }
        }
    }
}