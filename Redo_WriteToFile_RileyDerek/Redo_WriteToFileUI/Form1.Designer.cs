
namespace Redo_WriteToFileUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.lastTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.ReadinglistBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(145, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Person";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(44, 178);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(95, 40);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "Write to File ";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(44, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(191, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(129, 132);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // lastTextBox
            // 
            this.lastTextBox.Location = new System.Drawing.Point(129, 88);
            this.lastTextBox.Name = "lastTextBox";
            this.lastTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastTextBox.TabIndex = 8;
            // 
            // middleTextBox
            // 
            this.middleTextBox.Location = new System.Drawing.Point(129, 52);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleTextBox.TabIndex = 9;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(129, 16);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTextBox.TabIndex = 10;
            // 
            // ReadinglistBox
            // 
            this.ReadinglistBox.FormattingEnabled = true;
            this.ReadinglistBox.Location = new System.Drawing.Point(371, 5);
            this.ReadinglistBox.Name = "ReadinglistBox";
            this.ReadinglistBox.Size = new System.Drawing.Size(166, 186);
            this.ReadinglistBox.TabIndex = 11;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(371, 224);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(119, 40);
            this.showButton.TabIndex = 12;
            this.showButton.Text = "button1";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 313);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.ReadinglistBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(this.lastTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox lastTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.ListBox ReadinglistBox;
        private System.Windows.Forms.Button showButton;
    }
}

