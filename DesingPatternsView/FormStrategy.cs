using Strategy;
using System;
using System.Windows.Forms;

namespace DesingPatternsView
{
    public partial class FormStrategy : Form
    {
        public FormStrategy()
        {
            InitializeComponent();
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
    }
}