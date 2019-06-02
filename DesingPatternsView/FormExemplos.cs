using System;
using System.Windows.Forms;

namespace DesingPatternsView
{
    public partial class FormExemplos : Form
    {
        public FormExemplos()
        {
            InitializeComponent();
        }

        private void BtnChain_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormChainOfResponsibility().ShowDialog();
            Visible = true;
        }

        private void BtnStrategy_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormStrategy().ShowDialog();
            Visible = true;
        }
    }
}