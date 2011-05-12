using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Date aDate = new Date();
            Date anotherDate = new Date(2003, 11, 5);
            Console.WriteLine("aDate:\n" + aDate);
            Console.WriteLine("anotherDate:\n" + anotherDate);
        }
    }
}
