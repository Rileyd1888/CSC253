using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonClassLibrary;

//
//09/26/21
//CSC 253
//Derek Riley
// Writing into a person class and then saving it to a file 
//


namespace WriteClassUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            string userName = nameTextBox.Text;
           

            Person.readName(userName);
          

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text
            nameTextBox.Text = " ";
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }
    }
}
