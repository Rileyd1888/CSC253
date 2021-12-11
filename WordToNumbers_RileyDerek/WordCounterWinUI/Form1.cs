using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCounterLibrary;

namespace WordCounterWinUI
{
    //
    //CSC 253
    //09/05/21
    //Derek Riley
    //Creating a form that counts the amount of words 
    //
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            //Creating variable to read from textbox
            string myWord = wordCountTextBox.Text;

            // creating object from method 
           WordCount myWordCount = new WordCount();

            //getting rid of spaces and reading only the words
           string[] tokens = myWordCount.GettingCount(myWord).Split(null);

            //showing the number of words 
            answerLabel.Text = tokens.Length.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing the label and text box
            answerLabel.Text = "";
            wordCountTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closing program
            this.Close();
        }
    }
}
