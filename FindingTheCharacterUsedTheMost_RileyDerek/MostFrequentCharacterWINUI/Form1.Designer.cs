
namespace MostFrequentCharacterWINUI
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
            this.stringLabel = new System.Windows.Forms.Label();
            this.frequentLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringLabel
            // 
            this.stringLabel.AutoSize = true;
            this.stringLabel.Location = new System.Drawing.Point(40, 21);
            this.stringLabel.Name = "stringLabel";
            this.stringLabel.Size = new System.Drawing.Size(116, 13);
            this.stringLabel.TabIndex = 0;
            this.stringLabel.Text = "Enter Your String Here:";
            // 
            // frequentLabel
            // 
            this.frequentLabel.AutoSize = true;
            this.frequentLabel.Location = new System.Drawing.Point(40, 73);
            this.frequentLabel.Name = "frequentLabel";
            this.frequentLabel.Size = new System.Drawing.Size(141, 13);
            this.frequentLabel.TabIndex = 1;
            this.frequentLabel.Text = "The Most Frequent Letter Is:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(110, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(43, 132);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(172, 132);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(162, 18);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(135, 20);
            this.stringTextBox.TabIndex = 5;
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerLabel.Location = new System.Drawing.Point(197, 63);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(100, 23);
            this.answerLabel.TabIndex = 6;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 249);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.frequentLabel);
            this.Controls.Add(this.stringLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stringLabel;
        private System.Windows.Forms.Label frequentLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label answerLabel;
    }
}

