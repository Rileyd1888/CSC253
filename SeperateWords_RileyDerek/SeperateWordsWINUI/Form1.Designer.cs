
namespace SeperateWordsWINUI
{
    partial class Form1
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
            this.phraseLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.phraseTextBox = new System.Windows.Forms.TextBox();
            this.seperateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phraseLabel
            // 
            this.phraseLabel.AutoSize = true;
            this.phraseLabel.Location = new System.Drawing.Point(73, 61);
            this.phraseLabel.Name = "phraseLabel";
            this.phraseLabel.Size = new System.Drawing.Size(96, 13);
            this.phraseLabel.TabIndex = 0;
            this.phraseLabel.Text = "Enter Your Phrase:";
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerLabel.Location = new System.Drawing.Point(95, 105);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(227, 60);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phraseTextBox
            // 
            this.phraseTextBox.Location = new System.Drawing.Point(187, 54);
            this.phraseTextBox.Name = "phraseTextBox";
            this.phraseTextBox.Size = new System.Drawing.Size(183, 20);
            this.phraseTextBox.TabIndex = 2;
            // 
            // seperateButton
            // 
            this.seperateButton.Location = new System.Drawing.Point(109, 211);
            this.seperateButton.Name = "seperateButton";
            this.seperateButton.Size = new System.Drawing.Size(75, 23);
            this.seperateButton.TabIndex = 3;
            this.seperateButton.Text = "Seperate";
            this.seperateButton.UseVisualStyleBackColor = true;
            this.seperateButton.Click += new System.EventHandler(this.seperateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 240);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(247, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 328);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.seperateButton);
            this.Controls.Add(this.phraseTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.phraseLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phraseLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox phraseTextBox;
        private System.Windows.Forms.Button seperateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

