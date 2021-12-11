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

namespace AverageNumberWINUI
{
    // 
    //CSC 253 
    //Derek Riley
    //09/05/21
    //Creating a program that calculates the average of words typed
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
            string myWord = wordTextBox.Text;

            // creating object from method 
            WordCount myWordCount = new WordCount();

            //getting rid of spaces and reading only the words
            string[] tokens = myWordCount.GettingCount(myWord).Split(null);

            //showing the number of words 
            answerLabel.Text = tokens.Length.ToString();

            char letter;

            for (int index = 0; index < myWord.Length; index++)
            {
                letter = myWord[index];
                int total = index / tokens.Length;
                averageLabel.Text = total.ToString();
            }
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear 
            wordTextBox.Text = "";
            answerLabel.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }
    }
}
