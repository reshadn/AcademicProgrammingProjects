using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("dnc I am {0} cat", this.animalName);
        }
        public Cat(string name)
        {
            Console.WriteLine("dpc I am {0} cat", name);
        }
        public override void Noise()
        {
            Console.WriteLine("Meow! Meow!");
        }
        public override string aboutAnimal()
        {
            return "The animal class was revised by Cat \n" +
                "because cats are mischievous\n" +
                "08/11/08";
        }
    }
}
