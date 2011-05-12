using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnotherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mol = MyMethod(3);
            Console.WriteLine(mol.ToString());
        }
        public static int MyMethod(int someData)
        {

            Console.WriteLine("someData = {0}", someData.ToString());
            return 42; 
        }
    }
}
