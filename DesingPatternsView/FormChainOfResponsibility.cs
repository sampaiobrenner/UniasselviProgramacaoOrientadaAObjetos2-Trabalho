using ChainOfResponsibility;
using System;
using System.Windows.Forms;

namespace DesingPatternsView
{
    public partial class FormChainOfResponsibility : Form
    {
        public FormChainOfResponsibility()
        {
            InitializeComponent();
        }

        private void BtnDesconto_Click(object sender, EventArgs e)
        {
            ExemplosChain.Desconto();
        }

        private void BtnDiagrama_Click(object sender, EventArgs e)
        {
            panelDiagrama.Visible = true;
        }

        private void BtnRequisicao_Click(object sender, EventArgs e)
        {
            ExemplosChain.Requisicao();
        }

        private void LinkFecharDiagrama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelDiagrama.Visible = false;
        }
    }
}