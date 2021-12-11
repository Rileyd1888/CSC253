using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_ClassLibrary;
//
// CSC 253
// 08/29/21
// Derek Riley
// Showing a car accelerate and brake
//
namespace Car_Rileyd
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
         
        private void accerlerateButton_Click(object sender, EventArgs e)
        {   // creating object
            Car myCar = new Car(1997,"chevy");

           // accelrate 
            speedAnswerLabel.Text = myCar.accelerateSpeed().ToString();
           
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {   // creating object 
            Car myCar = new Car();
            // breake 
            speedAnswerLabel.Text = myCar.decelerateSpeed().ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear box
            speedAnswerLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close program
            this.Close();
        }

    }
}
