using System;
using System.Collections.Generic;

namespace Observer.ObserverNotaFiscal
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double impostos, DateTime dataDeEmissao,
            string observacoes, IList<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorBruto = valorBruto;
            Impostos = impostos;
            DataDeEmissao = dataDeEmissao;
            Obstervacoes = observacoes;
            Itens = itens;
        }

        public string Cnpj { get; }
        public DateTime DataDeEmissao { get; }
        public double Impostos { get; }
        public IList<ItemDaNota> Itens { get; }
        public string Obstervacoes { get; }
        public string RazaoSocial { get; }
        public double ValorBruto { get; }

        public void Imprime()
        {
            Console.WriteLine(RazaoSocial);
            Console.WriteLine(Cnpj);
            foreach (var item in Itens) Console.WriteLine("{0} - {1}", item.Nome, item.Valor);
            Console.WriteLine(ValorBruto);
            Console.WriteLine(Impostos);
            Console.WriteLine(DataDeEmissao.ToString("dd/MM/yyyy"));
            Console.WriteLine(Obstervacoes);
        }
    }
}