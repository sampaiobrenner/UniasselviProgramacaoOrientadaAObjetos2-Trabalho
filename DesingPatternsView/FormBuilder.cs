using Builder;
using System.Windows.Forms;

namespace DesingPatternsView
{
    public partial class FormBuilder : FormModelo
    {
        public FormBuilder()
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
            ExemplosBuilder.CriandoNotaFiscal();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }

        private void PrencherCampos()
        {
            txtParticipantes.Text =
                @"Director, Builder , Concrete Builder, Product ";

            txtExemploPratico.Text =
                @"Com o padrão Chain, evitamos a ocorrência de diversos condicionais aninhados, mantendo maior elegância e facilidade de manutenção " +
                @"em nossa aplicação. Caso de uma nova regra de negócio que precise ser implementada, basta criar uma nova classe e adicionar ela como " +
                @"próximo na sequência de execução. ";

            txtAplicacao.Text =
                @"Evitar a dependência entre um objeto receptor e um objeto solicitante. Consiste em uma série de objetos " +
                @"receptores e de objetos de solicitação, onde cada objetos de solicitação possui uma lógica interna que separa " +
                @"quais são tipos de objetos receptores que podem ser manipulados. O restante é passado para o próximo objetos de solicitação da cadeia." +
                @"Devido à isso, é um padrão que utiliza a ideia de baixo acoplamento por permitir que outros objetos da cadeia tenham a oportunidade de " +
                @"tratar uma solicitação";

            txtCategoria.Text =
                @"Comportamental";
        }
    }
}