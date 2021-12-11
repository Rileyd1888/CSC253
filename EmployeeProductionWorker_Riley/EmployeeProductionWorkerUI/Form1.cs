using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPWorkerLibrary;

//
//10/24/21  
//CSC 253
//Derek Riley 
//Creating an employee class that has properties and displays the objects properties
//

namespace EmployeeProductionWorkerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Creating the object
            ProductionWorker myproductionWorker = new ProductionWorker();

            myproductionWorker.Name = nameTextBox.Text;
            myproductionWorker.Number = int.Parse(enTextBox.Text.ToString());
            myproductionWorker.Shiftnumber = int.Parse(snTextBox.Text.ToString());
            myproductionWorker.HPR = decimal.Parse(hprTextBox.Text.ToString());

            //decision structure 
            if (myproductionWorker.Shiftnumber == 1)
            {
                informationBox.Text = myproductionWorker.Name + " " + myproductionWorker.Number + " " + "Day" + " " + myproductionWorker.HPR.ToString("c");
            }
            else
            {
                informationBox.Text = myproductionWorker.Name + " " + myproductionWorker.Number + " " + "Night" + " " + myproductionWorker.HPR.ToString("c");
            }
           
      
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing information
            informationBox.Text = " ";
            nameTextBox.Text = " ";
            enTextBox.Text = " ";
            snTextBox.Text = " ";
            hprTextBox.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }
    }
}
