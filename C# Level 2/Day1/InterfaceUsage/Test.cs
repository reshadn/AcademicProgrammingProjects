using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InterfaceUsage
{
    class Test
    {
        static void Main(string[] args)
        {
            //instance of each class: objects created
            Person aPerson = new Person("Bill", "Gates", 1961);
            OakTree aTree = new OakTree(1830);
            Dog aDog = new Dog("Fido", 1995);

            //Interface array that uses each of the class instances
            //casting to the base ??why casting to base??
            IUniversalAge[] iAge = new IUniversalAge[3];

            iAge[0] = aPerson;
            iAge[1] = aTree;
            iAge[2] = aDog;

            //optional problem: write to a text file your class instance data
            string fileSpec = "LogData.txt";
            StreamWriter output = File.CreateText(fileSpec);

            //Print out each member of the Interface array 
            foreach (IUniversalAge ageData in iAge)
            {
                Console.WriteLine("Data Type: {0}", ageData.ToString());
                Console.WriteLine("\tName: {0}", ageData.Name);
                Console.WriteLine("\tUniversal Age: {0}", ageData.Age);
                //optional problem
                output.Write(ageData.ToString());
                output.Write(" " + ageData.Name);
                output.WriteLine(" " + ageData.Age);
            }
            output.Close();
        }
    }
}
