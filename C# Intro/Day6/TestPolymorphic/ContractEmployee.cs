using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPolymorphic
{
    class ContractEmployee : Employee
    {
        public ContractEmployee(string name)
            : base(name)
        {
            Console.WriteLine("ContractEmployee base class called");
        }

        public override void CalculatePay()
        {
            Console.WriteLine("ContractEmployee.CalculatePay called for {0}\n", this.Name);
        }
    }
}
