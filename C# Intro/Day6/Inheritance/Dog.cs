using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Dog: Animal
    {
        public Dog()
        {
            Console.WriteLine("dnc I am {0} dog", this.animalName);
        }
        public Dog(string name)
            : base(name)
        {
            Console.WriteLine("dpc I am {0} dog", name);
        }
        public override void Noise()
        {
            Console.WriteLine("Bark! Bark!");
        }
    }
}
