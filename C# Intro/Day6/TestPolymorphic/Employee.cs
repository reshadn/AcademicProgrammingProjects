using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPolymorphic
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
}
