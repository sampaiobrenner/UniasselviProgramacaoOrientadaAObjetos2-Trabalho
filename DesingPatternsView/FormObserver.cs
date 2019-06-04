using Observer;

namespace DesingPatternsView
{
    public partial class FormObserver : FormModelo
    {
        public FormObserver()
        {
            InitializeComponent();
            PrencherCampos();
        }

        private void BtnDiagrama_Click(object sender, System.EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnNotaFiscal_Click(object sender, System.EventArgs e)
        {
            ExemplosObserver.Observer();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }

        private void PrencherCampos()
        {
            txtParticipantes.Text =
                @" ";

            txtExemploPratico.Text =
                @"";
            txtAplicacao.Text =
                @"";

            txtCategoria.Text =
                @"Comportamental";
        }
    }
}