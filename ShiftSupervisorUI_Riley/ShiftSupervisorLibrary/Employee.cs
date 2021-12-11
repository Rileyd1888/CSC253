using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLibrary
{
    public class Employee
    {
        //Constructor
        public Employee()
        {
            Name = " ";
            Number = 0;
        }
        // Constructor
        public Employee(string name, int number)
        {
            Name = name;
            Number = number;
        }
        // Properties 
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
