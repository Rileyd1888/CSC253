using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaderLibrary;

//
//09/26/21
// CSC 253
// Derek Riley
// Reading my Person File 
//
//

namespace ReadingmyFileUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // show items in listbox
            listBox1.Items.Add(Reader.ReadPeopleFile());

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close
            this.Close();
        }
    }
}
