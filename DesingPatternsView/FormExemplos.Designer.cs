namespace DesingPatternsView
{
    partial class FormExemplos
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
            this.btnStrategy = new System.Windows.Forms.Button();
            this.btnChain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrategy
            // 
            this.btnStrategy.Location = new System.Drawing.Point(36, 33);
            this.btnStrategy.Name = "btnStrategy";
            this.btnStrategy.Size = new System.Drawing.Size(222, 62);
            this.btnStrategy.TabIndex = 0;
            this.btnStrategy.Text = "Strategy";
            this.btnStrategy.UseVisualStyleBackColor = true;
            this.btnStrategy.Click += new System.EventHandler(this.BtnStrategy_Click);
            // 
            // btnChain
            // 
            this.btnChain.Location = new System.Drawing.Point(36, 101);
            this.btnChain.Name = "btnChain";
            this.btnChain.Size = new System.Drawing.Size(222, 62);
            this.btnChain.TabIndex = 1;
            this.btnChain.Text = "Chain of Responsability";
            this.btnChain.UseVisualStyleBackColor = true;
            this.btnChain.Click += new System.EventHandler(this.BtnChain_Click);
            // 
            // FormExemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.btnChain);
            this.Controls.Add(this.btnStrategy);
            this.MaximizeBox = false;
            this.Name = "FormExemplos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desing Patterns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrategy;
        private System.Windows.Forms.Button btnChain;
    }
}