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

        private void BtnRequisicao_Click(object sender, EventArgs e)
        {
            ExemplosChain.Requisicao();
        }
    }
}