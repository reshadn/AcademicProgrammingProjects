using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOL
{
    public delegate void WorkStarted();
    public delegate void WorkProgressing();
    public delegate int WorkCompleted();

    class Program
    {
        static void Main(string[] args)
        {
            Universe.InTheBeginning();
            Console.WriteLine("Program Area: In wait state...");
            Console.ReadLine();
            Console.WriteLine("Program Area: That's all folks!");
        }
    }
}
