using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void DataOut(out int i)
        {
            i = 10;
        }

        static void Main(string[] args)
        {
            int j;
            DataOut(out j);
            Console.WriteLine(j); // what value is j?
        }
    }
}
