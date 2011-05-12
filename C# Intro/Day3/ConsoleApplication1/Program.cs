using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int AddData(ref int a, ref int b)
        {
            a = 2;
            return a + b;
        }

        static void Main(string[] args)
        {
            int c = 1;
            int d = 2;
            int retValue = 0;
            retValue = AddData(ref c, ref d);
            Console.WriteLine(c); // what is displayed? retValue=4

        }
    }
}
