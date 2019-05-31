using System;
using System.Collections.Generic;

namespace Builder.BuilderNotaFiscal
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double impostos, DateTime dataDeEmissao, string observacoes, IList<ItemDaNota> itens)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.DataDeEmissao = dataDeEmissao;
            this.Obstervacoes = observacoes;
            this.Itens = itens;
        }

        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens { get; private set; }
        public string Obstervacoes { get; private set; }
        public string RazaoSocial { get; private set; }
        public double ValorBruto { get; private set; }

        public void Imprime()
        {
            Console.WriteLine(RazaoSocial);
            Console.WriteLine(Cnpj);
            foreach (var item in Itens)
            {
                Console.WriteLine("{0} - {1}", item.Nome, item.Valor);
            }
            Console.WriteLine(ValorBruto);
            Console.WriteLine(Impostos);
            Console.WriteLine(DataDeEmissao.ToString("dd/MM/yyyy"));
            Console.WriteLine(Obstervacoes);
        }
    }
}