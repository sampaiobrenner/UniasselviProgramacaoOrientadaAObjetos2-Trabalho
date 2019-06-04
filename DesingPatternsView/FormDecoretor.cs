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
                @"Client, Component, Concrete component, base decorator e concrete decorator.";

            txtExemploPratico.Text =
                @"Um exemplo simples e prático da aplicação do Decorator seria colocar acessórios em uma arma, como miras e silenciadores. " +
                @"Um modo de se contornar esse problema seria criar uma interface e criar armas que implementam essa interface. " +
                @"(Arma sem acessórios, arma com silenciador, arma com mira, arma com mira e silenciador). Outra solução seria utilizar o Design Pattern Decorator. ";

            txtAplicacao.Text =
                @"Decorator é um padrão de projeto de software que permite adicionar um comportamento a um objeto já existente " +
                @"em tempo de execução, ou seja, agrega dinamicamente responsabilidades adicionais a um objeto. ";

            txtCategoria.Text =
                @"Estrutural";
        }
    }
}