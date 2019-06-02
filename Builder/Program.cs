using System;
using Builder.BuilderNotaFiscal;

namespace Builder
{
    internal class Program
    {
        private static void Builder()
        {
            var itemBuilder = new ItemDaNotaBuilder();
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

            var builder = new NotaFiscalBuilder();
            builder
                .ComRazaoSocial("Filomeno Advogados")
                .ComCnpj("24.093.094/0001.59")
                .Com(item1)
                .Com(item2)
                .Com(item3)
                .ComObservacoes("uma observacao qualquer");

            var nota = builder.Constroi();

            nota.Imprime();

            Console.ReadKey();
        }

        private static void Main(string[] args)
        {
            Builder();
        }
    }
}