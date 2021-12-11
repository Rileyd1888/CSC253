using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomLibrary;
//
//CSC 253
//Derek Riley
//09/15/21
//Random Numbers to a txt file 
//
//

namespace RandomNumberUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            // variable to see how many random numbers are created 
            int howMany = int.Parse(randomTextBox.Text);
            // variable to give exception message
            int exceptionReturn = RaNum.randomNumbers(howMany);

            // decision structure 
            if (exceptionReturn > 100)
            {
                MessageBox.Show("Enter a valid number");
            }
            else
            {
                MessageBox.Show("The numbers are in the file.");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        { //exit program
            this.Close();
        }
    }
}
