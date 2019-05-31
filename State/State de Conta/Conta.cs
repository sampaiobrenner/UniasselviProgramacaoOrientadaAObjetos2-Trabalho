using State.State_de_Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Conta
    {
        public interface IEstadoDeConta
        {
            void Saca(Conta conta, double valor);
            void Deposita(Conta conta, double valor);
        }

        public class Positivo : IEstadoDeConta
        {
            public void Saca(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                if (conta.Saldo < 0)
                {
                    conta.EstadoDaConta = new Negativo();
                }

            }
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += (valor * 0.98);
            }


        }
        public class Negativo : IEstadoDeConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += (valor * 0.95);
                if (conta.Saldo >= 0)
                {
                    conta.EstadoDaConta = new Positivo();
                }
            }

            public void Saca(Conta conta, double valor)
            {
                throw new Exception("Contas negativas não podem efetuar saques");
            }
        }

        public IEstadoDeConta EstadoDaConta { get; set; }

        public double Saldo { get; private set; }


        public Conta(double saldo)
        {
            this.Saldo = saldo;
            if (saldo <0)
            {
                EstadoDaConta = new Negativo();
            }
            else
            {
                EstadoDaConta = new Positivo();
            }
            
        }

        public void Deposita(double valor)
        {
            EstadoDaConta.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            EstadoDaConta.Saca(this, valor);
        }
}
}
