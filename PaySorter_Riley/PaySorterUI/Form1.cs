using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
//10/03/21
//CSC 253
//Derek Riley 
// Sorying Database by Hourly Pay   
//

namespace PaySorterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        }

        private void asendingButton_Click(object sender, EventArgs e)
        {
            // code to make table go in Asending order 
            this.employeeTableAdapter.FillByEmployeeASC(this.employeeDataSet.Employee);
        }

        private void desendingButton_Click(object sender, EventArgs e)
        {
            // code to make table go in Desending order
            this.employeeTableAdapter.FillByEmployeeDesc(this.employeeDataSet.Employee);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit data    
            this.Close();
        }
    }
}
