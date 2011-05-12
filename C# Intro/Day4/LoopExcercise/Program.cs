using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "Cost of Living increases:\n\nEmployee No." +
                "\tOld Salary\tCost of Living Increase\n";
            decimal costOfLiving = .03M;
            decimal[] oldEmployeeSalary = { 4500M, 5200M, 7200M }; 
            // first salary = Employee No. 1
            // second salary = employee no. 2
            // third salary = employee no. 3

            int employeeNumber = 0;
            foreach (decimal holdSalary in oldEmployeeSalary)
            {
                // write the code logic to calculate cost of living expenses
                //based upon oldEmployeeSalary * costOfLiving, ie:
                //

                employeeNumber++;
                output += employeeNumber.ToString() + "\t\t" +
                    holdSalary.ToString("C") + "\t" +
                    (oldEmployeeSalary[employeeNumber - 1] *
                    costOfLiving).ToString("C") +
                    "\n";
            }

            Console.WriteLine(output);
        }
    }
}
