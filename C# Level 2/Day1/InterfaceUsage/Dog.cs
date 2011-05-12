using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceUsage
{
    //Inherits from IUniversalAge
    public class Dog : IUniversalAge
    {
                    //private string firstName;
        //Data kept private: data encapsulation 
        //properties
        private string name;
        private int yearBorn;

        //no null constructor
        //constructor: purpose => used for initializing members of a class
        public Dog(string inName, int inYearBorn)
        {
            name = inName;
            if (inYearBorn > 0 && inYearBorn <= DateTime.Now.Year)
                yearBorn = inYearBorn;
            else
                yearBorn = DateTime.Now.Year;
        }

        // universal age property
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - yearBorn) * 7;
            }
        }

        //Name property, inherited from IUniversalAge
        public string Name
        {
            get
            {
                return name;
            }
        }

    }
}
