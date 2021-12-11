using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WriteReadLibrary;

namespace RedoReadingUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
           resultsListBox.Items.Add(Reader.ReadPeopleFile());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (DemoClass person in ListBuilder.people)
            {
                resultsListBox.Items.Add(person);
            }
          
              
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
