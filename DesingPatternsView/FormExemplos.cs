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

        private void AbrirTela(Form form)
        {
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }

        private void BtnBuilder_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormBuilder());
        }

        private void BtnChain_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormChainOfResponsibility());
        }

        private void BtnDecorator_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormDecoretor());
        }

        private void BtnObserver_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormObserver());
        }

        private void BtnState_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormState());
        }

        private void BtnStrategy_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormStrategy());
        }

        private void BtnTemplateMehod_Click(object sender, EventArgs e)
        {
            AbrirTela(new FormTemplateMethod());
        }
    }
}