using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Area;

//
// CSC 253
// 08/29/21
// Derek Riley
// Overloading Methods to get the area of a circle, cylinder and a rectange
//


namespace Area_Riley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            // showing the area of a rectangle 

            resultsLabel.Text = area_Overload.areaCircle(5.0).ToString();

        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {
          
            // showing the area of a cylinder with all the methods
            resultsLabel.Text = area_Overload.areaCylinder(5,10).ToString();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            // showing the area of a rectangle 
            resultsLabel.Text = area_Overload.areaRectangle(5.0m,12m).ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
