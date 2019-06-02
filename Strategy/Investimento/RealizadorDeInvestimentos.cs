using System.Globalization;
using System.Windows.Forms;

namespace Strategy.Investimento
{
    internal static class RealizadorDeInvestimentos
    {
        internal static void Calcula(Conta conta, IInvestimento investimento)
        {
            var valor = investimento.Calcula(conta);
            conta.Saldo += valor * 0.75;
            MessageBox.Show($"Saldo atual: {conta.Saldo.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}