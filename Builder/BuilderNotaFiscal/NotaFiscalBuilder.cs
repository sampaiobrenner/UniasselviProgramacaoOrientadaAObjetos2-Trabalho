using System;
using System.Collections.Generic;

namespace Builder.BuilderNotaFiscal
{
    public class NotaFiscalBuilder
    {
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
        }

        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double Impostos { get; private set; }
        public string Obstervacoes { get; private set; }
        public string RazaoSocial { get; private set; }
        public double ValorBruto { get; private set; }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            Impostos = ValorBruto * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Obstervacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscal Constroi()
        {
            var nota = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Obstervacoes, Itens);
            return nota;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            DataDeEmissao = novaData;
            return this;
        }
    }
}