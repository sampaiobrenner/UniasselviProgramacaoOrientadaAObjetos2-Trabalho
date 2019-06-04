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
                @"Contexto, Estado e superclasse EstadoConcreto";

            txtExemploPratico.Text =
                @"";
            txtAplicacao.Text =
                @"O padrão State é motivado por aqueles objetos que, em seu estado atual, varia o seu comportamento devido as diferentes mensagens que possa receber. " +
                @"Como exemplo, tomamos uma classe Livro, um objeto desta classe terá respostas diferentes, dependendo do seu estado(Disponível ou Emprestado). " +
                @"Por exemplo invocando o método reservar de um objeto da classe Livro seu comportamento será diferente, se o Livro está no estado Disponível " +
                @"ou no estado Emprestado. ";

            txtCategoria.Text =
                @"Comportamental";
        }
    }
}