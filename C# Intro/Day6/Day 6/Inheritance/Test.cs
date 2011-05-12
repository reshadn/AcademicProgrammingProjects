using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Test
    {
        static void Main(string[] args)
        {
            Dog aDog = new Dog();
            Console.WriteLine(aDog.ToString());

            Dog myDog = new Dog("Fido");
            myDog.Weight = 45;
            myDog.Noise();
            Console.WriteLine(myDog.ToString());

            Cat myCat = new Cat("Pus");
            myCat.Weight = 12;
            myCat.Noise();
            Console.WriteLine(myCat.ToString());
        }
    }
}
