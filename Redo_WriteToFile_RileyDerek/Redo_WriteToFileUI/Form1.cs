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

namespace Redo_WriteToFileUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            Writer.WriteToFile();
        }        
        private void addButton_Click(object sender, EventArgs e)
        {

            ListBuilder.people.Add(new DemoClass(firstTextBox.Text, middleTextBox.Text, lastTextBox.Text, int.Parse(ageTextBox.Text)));
            firstTextBox.Clear();
            middleTextBox.Clear();
            lastTextBox.Clear();
            ageTextBox.Clear();
           
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Reader.ReadPeopleFile());
            foreach (DemoClass person in ListBuilder.people)
            {
                ReadinglistBox.Items.Add(person.FirstName);
            }
        }
    }
}
