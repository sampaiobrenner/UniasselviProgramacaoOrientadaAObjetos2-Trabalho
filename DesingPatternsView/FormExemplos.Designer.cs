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
            this.btnTemplateMehod = new System.Windows.Forms.Button();
            this.btnDecorator = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.btnBuilder = new System.Windows.Forms.Button();
            this.btnObserver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnStrategy
            // 
            this.btnStrategy.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrategy.Location = new System.Drawing.Point(13, 49);
            this.btnStrategy.Margin = new System.Windows.Forms.Padding(2);
            this.btnStrategy.Name = "btnStrategy";
            this.btnStrategy.Size = new System.Drawing.Size(166, 50);
            this.btnStrategy.TabIndex = 0;
            this.btnStrategy.Text = "Strategy";
            this.btnStrategy.UseVisualStyleBackColor = true;
            this.btnStrategy.Click += new System.EventHandler(this.BtnStrategy_Click);
            // 
            // btnChain
            // 
            this.btnChain.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChain.Location = new System.Drawing.Point(184, 49);
            this.btnChain.Margin = new System.Windows.Forms.Padding(2);
            this.btnChain.Name = "btnChain";
            this.btnChain.Size = new System.Drawing.Size(166, 50);
            this.btnChain.TabIndex = 1;
            this.btnChain.Text = "Chain of Responsability";
            this.btnChain.UseVisualStyleBackColor = true;
            this.btnChain.Click += new System.EventHandler(this.BtnChain_Click);
            // 
            // btnTemplateMehod
            // 
            this.btnTemplateMehod.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplateMehod.Location = new System.Drawing.Point(13, 104);
            this.btnTemplateMehod.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemplateMehod.Name = "btnTemplateMehod";
            this.btnTemplateMehod.Size = new System.Drawing.Size(166, 50);
            this.btnTemplateMehod.TabIndex = 2;
            this.btnTemplateMehod.Text = "Template Method";
            this.btnTemplateMehod.UseVisualStyleBackColor = true;
            this.btnTemplateMehod.Click += new System.EventHandler(this.BtnTemplateMehod_Click);
            // 
            // btnDecorator
            // 
            this.btnDecorator.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecorator.Location = new System.Drawing.Point(184, 104);
            this.btnDecorator.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecorator.Name = "btnDecorator";
            this.btnDecorator.Size = new System.Drawing.Size(166, 50);
            this.btnDecorator.TabIndex = 3;
            this.btnDecorator.Text = "Decorator";
            this.btnDecorator.UseVisualStyleBackColor = true;
            this.btnDecorator.Click += new System.EventHandler(this.BtnDecorator_Click);
            // 
            // btnState
            // 
            this.btnState.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(13, 159);
            this.btnState.Margin = new System.Windows.Forms.Padding(2);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(166, 50);
            this.btnState.TabIndex = 4;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.BtnState_Click);
            // 
            // btnBuilder
            // 
            this.btnBuilder.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuilder.Location = new System.Drawing.Point(184, 159);
            this.btnBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuilder.Name = "btnBuilder";
            this.btnBuilder.Size = new System.Drawing.Size(166, 50);
            this.btnBuilder.TabIndex = 5;
            this.btnBuilder.Text = "Builder";
            this.btnBuilder.UseVisualStyleBackColor = true;
            this.btnBuilder.Click += new System.EventHandler(this.BtnBuilder_Click);
            // 
            // btnObserver
            // 
            this.btnObserver.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObserver.Location = new System.Drawing.Point(13, 214);
            this.btnObserver.Margin = new System.Windows.Forms.Padding(2);
            this.btnObserver.Name = "btnObserver";
            this.btnObserver.Size = new System.Drawing.Size(166, 50);
            this.btnObserver.TabIndex = 6;
            this.btnObserver.Text = "Observer";
            this.btnObserver.UseVisualStyleBackColor = true;
            this.btnObserver.Click += new System.EventHandler(this.BtnObserver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exemplos práticos - Desing Patterns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desenvolvido por Matheus Brenner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Disponível no GitHub:";
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(193, 305);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(113, 13);
            this.linkGithub.TabIndex = 10;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "https://bit.ly/2wwgIxH";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGithub_LinkClicked);
            // 
            // FormExemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 336);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObserver);
            this.Controls.Add(this.btnBuilder);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnDecorator);
            this.Controls.Add(this.btnTemplateMehod);
            this.Controls.Add(this.btnChain);
            this.Controls.Add(this.btnStrategy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormExemplos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desing Patterns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrategy;
        private System.Windows.Forms.Button btnChain;
        private System.Windows.Forms.Button btnTemplateMehod;
        private System.Windows.Forms.Button btnDecorator;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnBuilder;
        private System.Windows.Forms.Button btnObserver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkGithub;
    }
}