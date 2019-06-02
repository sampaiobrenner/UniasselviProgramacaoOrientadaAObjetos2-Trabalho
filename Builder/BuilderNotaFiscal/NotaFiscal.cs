using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Builder.BuilderNotaFiscal
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
            Observacoes = observacoes;
            Itens = itens;
        }

        private string Cnpj { get; }
        private DateTime DataDeEmissao { get; }
        private double Impostos { get; }
        private IList<ItemDaNota> Itens { get; }
        private string Observacoes { get; }
        private string RazaoSocial { get; }
        private double ValorBruto { get; }

        public void Imprime()
        {
            var impressao = new StringBuilder()
                .Append($"Razão Social: {RazaoSocial}                                       {Environment.NewLine}")
                .Append($"CNPJ: {Cnpj}                                                      {Environment.NewLine}");

            foreach (var item in Itens)
                impressao.Append($"Item: {item.Nome} - Valor: {item.Valor}                  {Environment.NewLine}");

            var str = impressao
                .Append($"Valor Bruto: {ValorBruto}                                         {Environment.NewLine}")
                .Append($"Impostos: {Impostos}                                              {Environment.NewLine}")
                .Append($"Data de emisssão {DataDeEmissao:dd/MM/yyyy}                       {Environment.NewLine}")
                .Append($"Observações {Observacoes}                                         {Environment.NewLine}")
                .ToString();

            MessageBox.Show(str);
        }
    }
}