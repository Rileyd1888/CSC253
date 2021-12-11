using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopulationDatabaseUI
{
    //
    //10/10/21
    //CSC 253
    //Derek Riley 
    // Using the Population Database that was provided to sort populations (Asending, Desending
    // by name) show the highest, lowest, average and total population in a label. 
    //
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        private void sortAscButton_Click(object sender, EventArgs e)
        {
            // method to organize table by Asending Population 
            this.cityTableAdapter.FillByASCPopulation(this.populationDBDataSet.City);
        }

        private void sortDescButton_Click(object sender, EventArgs e)
        {
            // method to organize table by Desending Population 
            this.cityTableAdapter.FillByDescPopulation(this.populationDBDataSet.City);
        }

        private void sortNameButton_Click(object sender, EventArgs e)
        {
            // method to organize table by name
            this.cityTableAdapter.FillByName(this.populationDBDataSet.City);
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            // creating variable 
            int sumPopulation;
            // using variable to add adapter. 
            sumPopulation = (int)this.cityTableAdapter.SumPop();
            // putting info into the label 
            answerLabel.Text = "The sum population of all the cities is: " +
                sumPopulation.ToString();
        }

        private void avgButton_Click(object sender, EventArgs e)
        {   
            // creating variable 
            int avgPopulation;
            // using variable to add adapter. 
            avgPopulation = (int)this.cityTableAdapter.AvgPopulation();
            // putting info into the label 
            answerLabel.Text = "The average population of all the cities is: " +
                avgPopulation.ToString();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {   
            // creating variable 
            int maxPopulation;
            // using variable to add adapter. 
            maxPopulation = (int)this.cityTableAdapter.HighestPopulation();
            // putting info into the label 
            answerLabel.Text = "The city with the highest population has a population of: " +
                maxPopulation.ToString();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            // creating variable 
            int minPopulation;
            // using variable to add adapter. 
            minPopulation = (int)this.cityTableAdapter.LowestPopulation();
            // putting info into the label 
            answerLabel.Text = "The city with the lowest population is has a population of: " +
                minPopulation.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear label
            answerLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close program 
            this.Close();
        }
    }
}
