using Builder.BuilderNotaFiscal;
using System;

namespace Builder
{
    public static class ExemplosBuilder
    {
        public static void CriandoNotaFiscal()
        {
            var item1 = new ItemDaNotaBuilder()
                .WithNome("Televisão")
                .WithValor(1200)
                .Build();

            var item2 = new ItemDaNotaBuilder()
                .WithNome("Notebook")
                .WithValor(1500)
                .Build();

            var item3 = new ItemDaNotaBuilder()
                .WithNome("Play Station 4")
                .WithValor(2900)
                .Build();

            var nota = new NotaFiscalBuilder()
                .WithrazaoSocial("Loja do Brenner")
                .WithCnpj("24.093.094/0001.59")
                .WithData(DateTime.Now)
                .WithItem(item1)
                .WithItem(item2)
                .WithItem(item3)
                .WithObservacoes("Entregar no local de trabalho em horário comercial. ")
                .Build();

            nota.Imprime();
        }
    }
}