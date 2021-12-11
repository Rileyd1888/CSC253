using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtentionLibrary;

// 
// 10/31/21
// CSC 253
// Derek Riley 
// Learning how to do extentions 
//

namespace ExtentionMethodsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Get input 
            String input = stringTextBox.Text;


            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (i < input.Length)
                {
                    extensionListBox.Items.Add(input[i] + "");
                }


            }

        }

        private void countButton_Click(object sender, EventArgs e)
        {
            // display and variable 
            string input = countTextBox1.Text;
            extensionListBox.Items.Add(input.stringCount()); 
        }

        private void phoneNumberButton2_Click(object sender, EventArgs e)
        {
            // Display and variable
            string input = telephoneTextBox2.Text;
            extensionListBox.Items.Add(input.stringToCharString());
        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            // display and variable 
            String input = dateTextBox.Text;
            extensionListBox.Items.Add(input.stringToString()); // works

        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            //display and variable 
            string input = backwardstextBox.Text;
            extensionListBox.Items.Add(input.backwardsString()); 
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear
            extensionListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {  
            //Exit
            this.Close();
        }
    }
}
