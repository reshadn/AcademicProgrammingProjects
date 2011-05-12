using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNumber = 1;
            int aSecondNumber = ++aNumber;

            aSecondNumber += 2;                 // same as next line (shortcut)
            aSecondNumber = aSecondNumber + 2;

            int aThirdNumber = 3;

            int aFourthNumber = aNumber +
                aSecondNumber * aThirdNumber;

            int aFifthNumber = 42;

            int aSixthNumber = aFifthNumber++;

            bool aBooleanValue = (aFifthNumber == aSixthNumber);

            Console.WriteLine("aFourthNumber = {0} aBooleanValue = {1}",
                aFourthNumber, aBooleanValue);
        }
    }
}
