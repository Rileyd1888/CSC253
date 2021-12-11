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
// 10/31/21
// CSC 253
// Derek Riley 
// Creating a program for the team leader   
//

namespace TeamLeaderUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // creating team leader
            TeamLeader myteamLeader = new TeamLeader();

            // creating the object that holds in formation 
            myteamLeader.Name = nameTextBox.Text;
            myteamLeader.Number = int.Parse(idTextBox.Text.ToString());
            myteamLeader.Shiftnumber = int.Parse(shiftTextBox.Text.ToString());
            myteamLeader.HPR = decimal.Parse(hprTextBox.Text.ToString());
            myteamLeader.MonthlyBonusAmount = decimal.Parse(bonusTextBox.Text.ToString());
            myteamLeader.TrainingHoursNeeded = int.Parse(requiredTextBox.Text.ToString());
            myteamLeader.TrainingHoursCompleted = int.Parse(completedTextBox.Text.ToString());

            // show infomation 
            MessageBox.Show(myteamLeader.Name +" \n" + " Team Leader ID: " + myteamLeader.Number.ToString()
                + "\n" + " shift number: " + myteamLeader.Shiftnumber.ToString() + "\n"
                + " Your hourly pay is: "
                + myteamLeader.HPR.ToString("c") + "\n" +
                " Your monthly bonus is: " + "\n" 
                + myteamLeader.MonthlyBonusAmount.ToString("c") + "\n"
                + "You have completed: "+ myteamLeader.TrainingHoursCompleted.ToString()
               + " hours. " + "\n" + "You need to complete: " +
               myteamLeader.TrainingHoursNeeded.ToString() + " hours");
            
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear boxes
            nameTextBox.Text = " ";
            idTextBox.Text = " ";
            shiftTextBox.Text = " ";
            hprTextBox.Text = " ";
            bonusTextBox.Text = " ";
            requiredTextBox.Text = " ";
            completedTextBox.Text = " ";

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close 
            this.Close();
        }
    }
}
