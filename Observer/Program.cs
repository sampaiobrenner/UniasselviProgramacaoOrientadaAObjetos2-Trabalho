using Observer.ObserverNotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer();
        }
        private static void Observer()
        {
            ItemDaNotaBuilder itemBuilder = new ItemDaNotaBuilder();
            itemBuilder
                .ComNome("item1")
                .ComValor(100);
            var item1 = itemBuilder.Constroi();
            itemBuilder
                .ComNome("item2")
                .ComValor(200);
            var item2 = itemBuilder.Constroi();
            itemBuilder
                .ComNome("item3")
                .ComValor(200);
            var item3 = itemBuilder.Constroi();

            List<IAcoesDaNotaFiscal> acoes = new List<IAcoesDaNotaFiscal>();

            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new Multiplicador(2));

            NotaFiscalBuilder builder = new NotaFiscalBuilder(acoes);
            builder
                .ComRazaoSocial("Filomeno Advogados")
                .ComCnpj("24.093.094/0001.59")
                .Com(item1)
                .Com(item2)
                .Com(item3)
                .ComObservacoes("uma observacao qualquer");
                //.ComAcao(new EnviadorDeEmail())
                //.ComAcao(new NotaFiscalDao())
                //.ComAcao(new Multiplicador(2));
                

            NotaFiscal nota = builder.Constroi();

            nota.Imprime();

            Console.ReadKey();
        }
    }
}
