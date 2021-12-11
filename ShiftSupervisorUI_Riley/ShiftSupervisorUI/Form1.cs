using SSLibrary;
using System;
using System.Windows.Forms;

//
//10/24/21
//CSC 253
//Derek Riley
//Creating a program for the shift supervisors information 
//

namespace ShiftSupervisorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // create object
            ShiftSupervisor myshiftSupervisor = new ShiftSupervisor();

            //Get user input for the information 
            myshiftSupervisor.Name = nameTextBox.Text;
            myshiftSupervisor.Number = int.Parse(eIDTextBox.Text.ToString());
            myshiftSupervisor.AnnualSalary = decimal.Parse(asTextBox.Text.ToString());
            myshiftSupervisor.AnnualProductionBonus = decimal.Parse(aPBTextBox.Text.ToString());

            MessageBox.Show("The shift supervisor name is " + myshiftSupervisor.Name + " and his employee number is " + myshiftSupervisor.Number
                + ". His annual salary is: " + myshiftSupervisor.AnnualSalary.ToString("c") + " and if production goes well they will get a  " 
                + myshiftSupervisor.AnnualProductionBonus.ToString("c") + " bonus.");
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text boxes
            asTextBox.Text = " ";
            eIDTextBox.Text = " ";
            nameTextBox.Text = " ";
            aPBTextBox.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close Program 
            this.Close();
        }
    }
}
