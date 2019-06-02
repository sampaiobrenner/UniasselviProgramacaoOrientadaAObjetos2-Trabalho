using System;
using System.Collections.Generic;

namespace Builder.BuilderNotaFiscal
{
    public class NotaFiscalBuilder
    {
        private readonly IList<ItemDaNota> _itens;

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
            _itens = new List<ItemDaNota>();
        }

        private string Cnpj { get; set; }
        private DateTime DataDeEmissao { get; set; }
        private double Impostos { get; set; }
        private string Observacoes { get; set; }
        private string RazaoSocial { get; set; }
        private double ValorBruto { get; set; }

        public NotaFiscal Build()
        {
            var nota = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Observacoes, _itens);
            return nota;
        }

        public NotaFiscalBuilder WithCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder WithData(DateTime novaData)
        {
            DataDeEmissao = novaData;
            return this;
        }

        public NotaFiscalBuilder WithItem(ItemDaNota item)
        {
            _itens.Add(item);
            ValorBruto += item.Valor;
            Impostos = ValorBruto * 0.05;
            return this;
        }

        public NotaFiscalBuilder WithObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder WithrazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }
    }
}