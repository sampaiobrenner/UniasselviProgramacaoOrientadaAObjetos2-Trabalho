using System;

namespace TemplateMethod.Imposto
{
    internal class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}