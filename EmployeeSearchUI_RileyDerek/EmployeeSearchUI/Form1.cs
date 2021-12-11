using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSearchUI
{
    //
    //
    // 10/05/21  
    // CSC 253 
    // Derek Riley 
    // Searching for an Employee Name 
    //
    //
    

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.EmployeeNSearch(this.employeeDataSet.Employee, searchTextBox.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }
    }
}
