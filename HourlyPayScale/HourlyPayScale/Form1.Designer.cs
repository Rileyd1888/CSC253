
namespace HourlyPayScale
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
            this.asendingButton = new System.Windows.Forms.Button();
            this.desendingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asendingButton
            // 
            this.asendingButton.Location = new System.Drawing.Point(37, 265);
            this.asendingButton.Name = "asendingButton";
            this.asendingButton.Size = new System.Drawing.Size(226, 83);
            this.asendingButton.TabIndex = 2;
            this.asendingButton.Text = "Asending ";
            this.asendingButton.UseVisualStyleBackColor = true;
            this.asendingButton.Click += new System.EventHandler(this.asendingButton_Click);
            // 
            // desendingButton
            // 
            this.desendingButton.Location = new System.Drawing.Point(269, 265);
            this.desendingButton.Name = "desendingButton";
            this.desendingButton.Size = new System.Drawing.Size(316, 83);
            this.desendingButton.TabIndex = 3;
            this.desendingButton.Text = "Desending ";
            this.desendingButton.UseVisualStyleBackColor = true;
            this.desendingButton.Click += new System.EventHandler(this.desendingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 360);
            this.Controls.Add(this.desendingButton);
            this.Controls.Add(this.asendingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button asendingButton;
        private System.Windows.Forms.Button desendingButton;
    }
}

