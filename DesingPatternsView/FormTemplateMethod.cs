using TemplateMethod;

namespace DesingPatternsView
{
    public partial class FormTemplateMethod : FormModelo
    {
        public FormTemplateMethod()
        {
            InitializeComponent();
            PrencherCampos();
        }

        private void BtnDiagrama_Click(object sender, System.EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnImposto_Click(object sender, System.EventArgs e)
        {
            ExemplosTemplateMethod.Imposto();
        }

        private void BtnRelatorio_Click(object sender, System.EventArgs e)
        {
            ExemplosTemplateMethod.Relatorio();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }

        private void PrencherCampos()
        {
            txtParticipantes.Text =
                @"Abstract class, Concrete class... ";

            txtExemploPratico.Text =
                @"";
            txtAplicacao.Text =
                @"Um Template Method auxilia na definição de um algoritmo com partes do mesmo definidos por métodos abstratos. " +
                @" As subclasses devem se responsabilizar por estas partes abstratas, deste algoritmo, que serão implementadas, " +
                @" possivelmente de várias formas, ou seja, cada subclasse irá implementar à sua necessidade e oferecer um comportamento " +
                @"concreto construindo todo o algoritmo.";

            txtCategoria.Text =
                @"Comportamental";
        }
    }
}