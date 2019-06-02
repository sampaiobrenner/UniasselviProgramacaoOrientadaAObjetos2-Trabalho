using Decorator;

namespace DesingPatternsView
{
    public partial class FormDecoretor : FormModelo
    {
        public FormDecoretor()
        {
            InitializeComponent();
            PrencherCampos();
        }

        private void BtnDiagrama_Click(object sender, System.EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnFiltroDeContas_Click(object sender, System.EventArgs e)
        {
            ExemplosDecorator.FiltroDeContas();
        }

        private void BtnImposto_Click(object sender, System.EventArgs e)
        {
            ExemplosDecorator.ImpostoComDecorator();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }

        private void LinkImagem1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            imagem1.Visible = true;
            imagem2.Visible = false;
        }

        private void LinkImagem2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            imagem1.Visible = false;
            imagem2.Visible = true;
        }

        private void PrencherCampos()
        {
            txtParticipantes.Text =
                @"Context, Strategy e ConcreteStrategy";

            txtExemploPratico.Text = "";

            txtAplicacao.Text = "";

            txtCategoria.Text =
                @"Comportamental";
        }
    }
}