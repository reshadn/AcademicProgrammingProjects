using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPolymorphic
{
    class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name)
            : base(name)
        {
            Console.WriteLine("SalariedEmployee base class called");
        }

        public override void CalculatePay()
        {
            Console.WriteLine("SalariedEmployee.CalculatePay called for {0}\n", this.Name);
        }
    }
}
