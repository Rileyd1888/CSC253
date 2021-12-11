
namespace Area_Riley
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
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(133, 241);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(94, 23);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "areaRectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(133, 183);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(94, 23);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "areaCircle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // cylinderButton
            // 
            this.cylinderButton.Location = new System.Drawing.Point(133, 212);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(94, 23);
            this.cylinderButton.TabIndex = 2;
            this.cylinderButton.Text = "areaCylinder";
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(133, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Location = new System.Drawing.Point(76, 48);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(211, 115);
            this.resultsLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 318);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cylinderButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.rectangleButton);
            this.Name = "Form1";
            this.Text = "Area Class";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button cylinderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultsLabel;
    }
}

