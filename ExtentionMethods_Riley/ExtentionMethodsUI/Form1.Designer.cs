
namespace ExtentionMethodsUI
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
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.extensionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countTextBox1 = new System.Windows.Forms.TextBox();
            this.telephoneTextBox2 = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.backwardstextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.phoneNumberButton2 = new System.Windows.Forms.Button();
            this.dateButton = new System.Windows.Forms.Button();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a String:";
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(172, 33);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(128, 20);
            this.stringTextBox.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(17, 244);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go ";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(425, 244);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(506, 244);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // extensionListBox
            // 
            this.extensionListBox.FormattingEnabled = true;
            this.extensionListBox.Location = new System.Drawing.Point(526, 40);
            this.extensionListBox.Name = "extensionListBox";
            this.extensionListBox.Size = new System.Drawing.Size(184, 173);
            this.extensionListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a string to count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Format Telephone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter a Date (mm/dd/yyyy):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter a String to turn backwards:";
            // 
            // countTextBox1
            // 
            this.countTextBox1.Location = new System.Drawing.Point(301, 75);
            this.countTextBox1.Name = "countTextBox1";
            this.countTextBox1.Size = new System.Drawing.Size(128, 20);
            this.countTextBox1.TabIndex = 10;
            // 
            // telephoneTextBox2
            // 
            this.telephoneTextBox2.Location = new System.Drawing.Point(301, 112);
            this.telephoneTextBox2.Name = "telephoneTextBox2";
            this.telephoneTextBox2.Size = new System.Drawing.Size(128, 20);
            this.telephoneTextBox2.TabIndex = 11;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(301, 154);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(128, 20);
            this.dateTextBox.TabIndex = 12;
            // 
            // backwardstextBox
            // 
            this.backwardstextBox.Location = new System.Drawing.Point(392, 193);
            this.backwardstextBox.Name = "backwardstextBox";
            this.backwardstextBox.Size = new System.Drawing.Size(128, 20);
            this.backwardstextBox.TabIndex = 14;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(101, 244);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 15;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // phoneNumberButton2
            // 
            this.phoneNumberButton2.Location = new System.Drawing.Point(182, 244);
            this.phoneNumberButton2.Name = "phoneNumberButton2";
            this.phoneNumberButton2.Size = new System.Drawing.Size(75, 23);
            this.phoneNumberButton2.TabIndex = 16;
            this.phoneNumberButton2.Text = "Number";
            this.phoneNumberButton2.UseVisualStyleBackColor = true;
            this.phoneNumberButton2.Click += new System.EventHandler(this.phoneNumberButton2_Click);
            // 
            // dateButton
            // 
            this.dateButton.Location = new System.Drawing.Point(263, 244);
            this.dateButton.Name = "dateButton";
            this.dateButton.Size = new System.Drawing.Size(75, 23);
            this.dateButton.TabIndex = 17;
            this.dateButton.Text = "Date";
            this.dateButton.UseVisualStyleBackColor = true;
            this.dateButton.Click += new System.EventHandler(this.dateButton_Click);
            // 
            // backwardsButton
            // 
            this.backwardsButton.Location = new System.Drawing.Point(344, 244);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(75, 23);
            this.backwardsButton.TabIndex = 18;
            this.backwardsButton.Text = "backwards";
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.backwardsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 293);
            this.Controls.Add(this.backwardsButton);
            this.Controls.Add(this.dateButton);
            this.Controls.Add(this.phoneNumberButton2);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.backwardstextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.telephoneTextBox2);
            this.Controls.Add(this.countTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.extensionListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox extensionListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countTextBox1;
        private System.Windows.Forms.TextBox telephoneTextBox2;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox backwardstextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button phoneNumberButton2;
        private System.Windows.Forms.Button dateButton;
        private System.Windows.Forms.Button backwardsButton;
    }
}

