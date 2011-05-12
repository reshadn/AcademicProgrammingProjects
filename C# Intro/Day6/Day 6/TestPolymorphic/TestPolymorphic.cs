using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPolyMorphic
{

    class TestPolymorphic
    {
        static protected Employee[] employees;

        public void LoadEmployees()
        {
            //simulating loading from database.
            employees = new Employee[2];

            employees[0] = new ContractEmployee("Adam Barr");
            Console.WriteLine();

            employees[1] = new SalariedEmployee("Max Benson");
            Console.WriteLine();
        }

        public static void DoPayroll()
        {
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                employees[i].CalculatePay();
            }
        }

        static void Main(string[] args)
        {
            
            LoadEmployees();
            DoPayroll();
        }
    }

}