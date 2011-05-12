// Warmup Exercise
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Review of Console Applications Using Notepad
/// </summary>

namespace WarmupExercise
{
    class WarmUp
    {
        static void Main(string[] args)
        {
            string aResponse = ""; // a string variable 

            /* Processing entered data
             * as a warmup exercise. Watch out, C# is case sensitive! */

            Console.Write("Enter a name (x to end) : ");
            while ((aResponse = (Console.ReadLine()).ToLower()) != "x")
            {
                switch (aResponse)
                {
                    case "bill":
                        Console.WriteLine("Bill Gates likes this choice!");
                        break;
                    case "jane":
                        Console.WriteLine("Jane was entered.");
                        break;
                    default:
                        Console.WriteLine("Neither Bill nor Jane was selected.");
                        break;
                }
            }
        }
    }
}