using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadingFromFileLibrary;
using System.IO;
//
// CSC 253 
// Derek Terrell Riley 
// 09/19/21
// Reading from the file I created of random numbers 
//
//

namespace ReadingFilesUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void showButton_Click(object sender, EventArgs e)
        {
               //show in answer in listbox
                answerListBox.Items.Add(ReadingNumber.fileReading().ToString());
                answerListBox.Items.Add(ReadingNumber.fileCount().ToString());
                int exceptionReturn = ReadingNumber.fileReading();
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear list box
            answerListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close 
            this.Close();
        }
    }
}
