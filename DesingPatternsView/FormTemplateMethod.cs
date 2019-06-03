using TemplateMethod;

namespace DesingPatternsView
{
    public partial class FormTemplateMethod : FormModelo
    {
        public FormTemplateMethod()
        {
            InitializeComponent();
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
    }
}