using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyMorphic
{
    class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("Employee base class called");
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public virtual void CalculatePay()
        {
            Console.WriteLine("Employee.CalculatePay called for {0}\n", name);
        }
    }

    class ContractEmployee : Employee
    {
        public ContractEmployee(string name) : base(name)
        {
            Console.WriteLine("ContractEmployee base class called");
        }

        public override void  CalculatePay()
        {
         	Console.WriteLine("ContractEmployee.CalculatePay called for {0}\n", this.Name);
        }
    }

    class SalariedEmployee : Employee
    {
        public SalariedEmployee (string name) : base(name)
        {
            Console.WriteLine("SalariedEmployee base class called");
        }

        public override void  CalculatePay()
        {
            Console.WriteLine("SalariedEmployee.CalculatePay called for {0}\n", this.Name);
        }
    }

    class TestPolymorphic
    {
        protected Employee[] employees;

        public void LoadEmployees()
        {
            //simulating loading from database.
            employees = new Employee[2];

            employees[0] = new ContractEmployee("Adam Barr");
            Console.WriteLine();

            employees[1] = new SalariedEmployee("Max Benson");
            Console.WriteLine();
        }

        public void DoPayroll()
        {
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                employees[i].CalculatePay();
            }
        }

        static void Main(string[] args)
        {
            TestPolymorphic t = new TestPolymorphic();
            t.LoadEmployees();
            t.DoPayroll();
        }
    }
    class TestPolymorphic
    {
        protected Employee[] employees;

        public void LoadEmployees()
        {
            //simulating loading from database.
            employees = new Employee[2];

            employees[0] = new ContractEmployee("Adam Barr");
            Console.WriteLine();

            employees[1] = new SalariedEmployee("Max Benson");
            Console.WriteLine();
        }

        public void DoPayroll()
        {
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                employees[i].CalculatePay();
            }
        }

        static void Main(string[] args)
        {
            TestPolymorphic t = new TestPolymorphic();
            t.LoadEmployees();
            t.DoPayroll();
        }
    }
}

