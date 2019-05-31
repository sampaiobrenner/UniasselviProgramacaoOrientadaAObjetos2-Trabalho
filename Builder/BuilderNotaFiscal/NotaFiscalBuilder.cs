using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BuilderNotaFiscal
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public string Obstervacoes { get; private set; }
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            DataDeEmissao = DateTime.Now;
        }
        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.DataDeEmissao = novaData;
            return this;
        }
        public NotaFiscalBuilder ComRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos = ValorBruto * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Obstervacoes = observacoes;
            return this;
        }
        public NotaFiscal Constroi()
        {
            NotaFiscal nota = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Obstervacoes, Itens);
            return nota;
        }
        

        
    }
}
