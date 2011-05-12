using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the object variables
            Employee employee = null;
            Employees employees = new Employees();
            Department department =
                new Department("IT", "Information Technology");

            //Add employee Larry Wilson
            employee = new Employee("43109",
                "Larry",
                "Robert",
                "Wilson",
                "Manager",
                GenderType.Male,
                MaritalStatusType.Married,
                new DateTime(1954, 6, 11),
                new DateTime(1996, 4, 11),
                "(213) 335-2226",
                "(310) 456-1234",
                11000,
                department);
            employees.Add(employee);

            //Add employee John Brown

            //Add employee Lizzy Jones

            //Loop and display each Employee's information
            foreach (Employee emp in employees)
            { Console.WriteLine(emp.ToString()); }

            Console.ReadLine();
        }
    }
}
