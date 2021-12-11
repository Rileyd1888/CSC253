using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeperateLibrary;

namespace SeperateWordsWINUI
{
    //
    //09/12/21
    //CSC 253 
    //Derek Terrell Riley
    //Creating a program that seperates words by the capital letter
    //
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void seperateButton_Click(object sender, EventArgs e)
        {
            // variable to get phrase
            string phone = phraseTextBox.Text;
            
            // Creating Object 
            Seperate mySeperate = new Seperate();

            answerLabel.Text = mySeperate.SeperatedWord(phone).ToString();




        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear Boxes 
            answerLabel.Text = " ";
            phraseTextBox.Text = " "; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close Program
            this.Close();
        }
    }
}
