using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordFindLibrary;




namespace MostFrequentCharacterWINUI
{
    public partial class Form1 : Form
    {
        //
        //09/12/21
        //CSC 253
        //Derek Riley
        //Finding the most frequent character
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // variable to use the textbox 
            string phraseType = stringTextBox.Text;
            // creating the object to use method 
            FindLetter myLetter = new FindLetter();

            // showing the most frequent 
            answerLabel.Text = myLetter.mostFrequent(phraseType).ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clearing boxes
            stringTextBox.Text = " ";
            answerLabel.Text = " ";
        } 

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close program
            this.Close();
        }
    }
}
