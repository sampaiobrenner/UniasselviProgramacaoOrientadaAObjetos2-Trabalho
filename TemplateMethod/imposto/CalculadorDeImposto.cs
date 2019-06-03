using System.Globalization;
using System.Windows.Forms;

namespace TemplateMethod.Imposto
{
    internal class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.Calcula(orcamento);
            MessageBox.Show(valor.ToString(CultureInfo.InvariantCulture));
        }
    }
}