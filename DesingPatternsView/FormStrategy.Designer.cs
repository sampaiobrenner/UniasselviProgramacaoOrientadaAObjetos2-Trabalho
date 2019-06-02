namespace DesingPatternsView
{
    partial class FormStrategy
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
            this.btnImposto = new System.Windows.Forms.Button();
            this.btnInvestimento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImposto
            // 
            this.btnImposto.Location = new System.Drawing.Point(81, 318);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(283, 109);
            this.btnImposto.TabIndex = 0;
            this.btnImposto.Text = "Executar exemplo imposto";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.BtnImposto_Click);
            // 
            // btnInvestimento
            // 
            this.btnInvestimento.Location = new System.Drawing.Point(408, 318);
            this.btnInvestimento.Name = "btnInvestimento";
            this.btnInvestimento.Size = new System.Drawing.Size(283, 109);
            this.btnInvestimento.TabIndex = 1;
            this.btnInvestimento.Text = "Executar exemplo investimento";
            this.btnInvestimento.UseVisualStyleBackColor = true;
            this.btnInvestimento.Click += new System.EventHandler(this.BtnInvestimento_Click);
            // 
            // FormStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnInvestimento);
            this.Controls.Add(this.btnImposto);
            this.MaximizeBox = false;
            this.Name = "FormStrategy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strategy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImposto;
        private System.Windows.Forms.Button btnInvestimento;
    }
}

