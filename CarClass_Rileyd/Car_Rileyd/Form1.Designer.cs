
namespace Car_Rileyd
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
            this.accerlerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accerlerateButton
            // 
            this.accerlerateButton.Location = new System.Drawing.Point(75, 189);
            this.accerlerateButton.Name = "accerlerateButton";
            this.accerlerateButton.Size = new System.Drawing.Size(75, 37);
            this.accerlerateButton.TabIndex = 0;
            this.accerlerateButton.Text = "Accelerate";
            this.accerlerateButton.UseVisualStyleBackColor = true;
            this.accerlerateButton.Click += new System.EventHandler(this.accerlerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(196, 189);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(75, 37);
            this.brakeButton.TabIndex = 1;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(75, 232);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 232);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(72, 107);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 13);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Speed:";
            // 
            // speedAnswerLabel
            // 
            this.speedAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedAnswerLabel.Location = new System.Drawing.Point(145, 88);
            this.speedAnswerLabel.Name = "speedAnswerLabel";
            this.speedAnswerLabel.Size = new System.Drawing.Size(126, 32);
            this.speedAnswerLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 281);
            this.Controls.Add(this.speedAnswerLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accerlerateButton);
            this.Name = "Form1";
            this.Text = "Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accerlerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label speedAnswerLabel;
    }
}

