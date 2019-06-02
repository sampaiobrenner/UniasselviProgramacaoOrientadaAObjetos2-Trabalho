using Strategy;
using System;
using System.Windows.Forms;

namespace DesingPatternsView
{
    public partial class FormStrategy : FormModelo
    {
        public FormStrategy()
        {
            InitializeComponent();
            PrencherCampos();
        }

        private void BtnDiagrama_Click(object sender, EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnImposto_Click(object sender, EventArgs e)
        {
            ExemplosStrategy.Imposto();
        }

        private void BtnInvestimento_Click(object sender, EventArgs e)
        {
            ExemplosStrategy.Investimento();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }

        private void PrencherCampos()
        {
            txtParticipantes.Text = 
                @"Context, Strategy e ConcreteStrategy";

            txtExemploPratico.Text =
                @"Com o padrão strategy, quando houver algum tipo de mudança no formato do calculo fiscal, não precisamos fazer " +
                @"nenhuma alteração na classe NotaFiscal, é só criarmos uma nova classe, implementar a interface IImposto e na variável imposto, " +
                @"da classe NotaFiscal passar a nova classe, que a NotaFiscal fará o calculo da mesma.";

            txtAplicacao.Text =
                @"Quando se necessita de um algoritmo que trata de modos diferentes os dados submetidos a ele. ";

            txtCategoria.Text = 
                @"Comportamental";
        }
    }
}