using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLibrary
{
   public class ShiftSupervisor : Employee
    {
        // Constructor 
        public ShiftSupervisor()
        {
            AnnualSalary = 0;
            AnnualProductionBonus = 0; 
        }
        // Constructor 
        public ShiftSupervisor(string name, int number, decimal annualSalary, decimal annualProductionBonus)
        {
            AnnualSalary = annualSalary;
            AnnualProductionBonus = annualProductionBonus;
        }
        // Properties
        public decimal AnnualSalary { get; set; }

        public decimal AnnualProductionBonus { get; set; }
    }
}
