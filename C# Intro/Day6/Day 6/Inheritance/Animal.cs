using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Animal
    {
        private static int objectCount = 0;
        protected string animalName;
        private int holdWeight = 0;
        public Animal()
        {
            objectCount += 1;
            animalName = "Unassigned";
            Console.WriteLine("Null constr from animal");
        }
        public Animal(string name)
        {
            objectCount += 1;
            animalName = name;
            Console.WriteLine("Parameter Constr from animal");
        }
        public int Weight
        {
            get
            {
                return holdWeight;
            }
            set
            {
                holdWeight = value;
            }
        }
        public string Name
        {
            get
            {
                return animalName;
            }
        }
        public abstract void Noise();
        public virtual string aboutAnimal()
        {
            return "The animal class was written 08/11/08";
        }
        public override string ToString()
        {
            return "Animal Data \n" +
                "\tAnimal Name: " + animalName + "\n" +
                "\tAnimal Weight: " + holdWeight + "\n" +
                "\tNumber of objects: " + objectCount + "\n" +
                aboutAnimal() + "\n";
        }
        }
    }
