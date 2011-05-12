using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjectDLLUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGreatClass aGreatClass = new MyGreatClass();
            Console.WriteLine("Meaning of life is {0}", aGreatClass.AMethod());
        }
    }
}
