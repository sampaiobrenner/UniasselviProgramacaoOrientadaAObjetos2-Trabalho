namespace DesingPatternsView
{
    partial class FormChainOfResponsibility
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRequisicao = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRequisicao
            // 
            this.btnRequisicao.Location = new System.Drawing.Point(408, 308);
            this.btnRequisicao.Name = "btnRequisicao";
            this.btnRequisicao.Size = new System.Drawing.Size(283, 109);
            this.btnRequisicao.TabIndex = 3;
            this.btnRequisicao.Text = "Executar exemplo requisicao";
            this.btnRequisicao.UseVisualStyleBackColor = true;
            this.btnRequisicao.Click += new System.EventHandler(this.BtnRequisicao_Click);
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(81, 308);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(283, 109);
            this.btnDesconto.TabIndex = 2;
            this.btnDesconto.Text = "Executar exemplo desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.BtnDesconto_Click);
            // 
            // FormChainOfResponsibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnRequisicao);
            this.Controls.Add(this.btnDesconto);
            this.Name = "FormChainOfResponsibility";
            this.Text = "Chain Of Responsibility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequisicao;
        private System.Windows.Forms.Button btnDesconto;
    }
}