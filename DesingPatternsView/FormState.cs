using State;

namespace DesingPatternsView
{
    public partial class FormState : FormModelo
    {
        public FormState()
        {
            InitializeComponent();
            PrencherCampos();
        }

        private void BtnConta_Click(object sender, System.EventArgs e)
        {
            ExemplosState.StateDeConta();
        }

        private void BtnDiagrama_Click(object sender, System.EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnOrcamento_Click(object sender, System.EventArgs e)
        {
            ExemplosState.StateDeOrcamento();
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