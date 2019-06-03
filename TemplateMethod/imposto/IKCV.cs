namespace TemplateMethod.Imposto
{
    public class IKCV : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500 && TemItemMaiorQue100(orcamento)) return orcamento.Valor * 0.1;

            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
                if (item.Valor > 100)
                    return true;
            return false;
        }
    }
}