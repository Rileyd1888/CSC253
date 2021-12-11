
namespace AverageNumberWINUI
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
            this.wordLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.showAnswerlabel = new System.Windows.Forms.Label();
            this.showAveragelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(22, 59);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(210, 13);
            this.wordLabel.TabIndex = 0;
            this.wordLabel.Text = "Enter the words that you want me to count:";
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerLabel.Location = new System.Drawing.Point(238, 96);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(182, 27);
            this.answerLabel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(117, 184);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 3;
            this.countButton.Text = "Count ";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(265, 184);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(238, 52);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(183, 20);
            this.wordTextBox.TabIndex = 5;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(238, 134);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(182, 30);
            this.averageLabel.TabIndex = 6;
            // 
            // showAnswerlabel
            // 
            this.showAnswerlabel.AutoSize = true;
            this.showAnswerlabel.Location = new System.Drawing.Point(80, 110);
            this.showAnswerlabel.Name = "showAnswerlabel";
            this.showAnswerlabel.Size = new System.Drawing.Size(131, 13);
            this.showAnswerlabel.TabIndex = 7;
            this.showAnswerlabel.Text = "You have this many words";
            // 
            // showAveragelabel
            // 
            this.showAveragelabel.AutoSize = true;
            this.showAveragelabel.Location = new System.Drawing.Point(114, 151);
            this.showAveragelabel.Name = "showAveragelabel";
            this.showAveragelabel.Size = new System.Drawing.Size(110, 13);
            this.showAveragelabel.TabIndex = 8;
            this.showAveragelabel.Text = "Your word average is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 305);
            this.Controls.Add(this.showAveragelabel);
            this.Controls.Add(this.showAnswerlabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.wordLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label showAnswerlabel;
        private System.Windows.Forms.Label showAveragelabel;
    }
}

