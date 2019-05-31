using System;
using System.Collections.Generic;

namespace Observer.ObserverNotaFiscal
{
    public class NotaFiscalBuilder
    {
        public IList<IAcoesDaNotaFiscal> Acoes = new List<IAcoesDaNotaFiscal>();
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public NotaFiscalBuilder(IList<IAcoesDaNotaFiscal> acoes)
        {
            this.Acoes = acoes;
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
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos = ValorBruto * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Obstervacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        //public NotaFiscalBuilder ComAcao(IAcoesDaNotaFiscal acao)
        //{
        //    this.Acoes.Add(acao);
        //    return this;
        //}
        public NotaFiscal Constroi()
        {
            NotaFiscal nota = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Obstervacoes, Itens);
            foreach (var acao in Acoes)
            {
                acao.Executa(nota);
            }

            return nota;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.DataDeEmissao = novaData;
            return this;
        }
    }
}