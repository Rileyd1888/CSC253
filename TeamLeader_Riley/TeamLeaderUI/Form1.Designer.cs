
namespace TeamLeaderUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.completedTextBox = new System.Windows.Forms.TextBox();
            this.requiredTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.hprTextBox = new System.Windows.Forms.TextBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(114, 210);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(76, 37);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show Information";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(316, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team Leader Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Leader ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Team Leader Shift:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Team Leader Hour Pay Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Team Leader Bonus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Required Training Hours:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Training Hours Completed:";
            // 
            // completedTextBox
            // 
            this.completedTextBox.Location = new System.Drawing.Point(291, 176);
            this.completedTextBox.Name = "completedTextBox";
            this.completedTextBox.Size = new System.Drawing.Size(100, 20);
            this.completedTextBox.TabIndex = 10;
            // 
            // requiredTextBox
            // 
            this.requiredTextBox.Location = new System.Drawing.Point(291, 150);
            this.requiredTextBox.Name = "requiredTextBox";
            this.requiredTextBox.Size = new System.Drawing.Size(100, 20);
            this.requiredTextBox.TabIndex = 11;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(291, 124);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.bonusTextBox.TabIndex = 12;
            // 
            // hprTextBox
            // 
            this.hprTextBox.Location = new System.Drawing.Point(291, 98);
            this.hprTextBox.Name = "hprTextBox";
            this.hprTextBox.Size = new System.Drawing.Size(100, 20);
            this.hprTextBox.TabIndex = 13;
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.Location = new System.Drawing.Point(291, 72);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(100, 20);
            this.shiftTextBox.TabIndex = 14;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(291, 48);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(291, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 257);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.shiftTextBox);
            this.Controls.Add(this.hprTextBox);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.requiredTextBox);
            this.Controls.Add(this.completedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Team Leader Info ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox completedTextBox;
        private System.Windows.Forms.TextBox requiredTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox hprTextBox;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

