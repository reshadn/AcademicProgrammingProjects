using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceUsage
{
    public class Person : IUniversalAge
    {
        // read only properties
        private string firstName;
        private string lastName;
        private int yearBorn;

        //constructor
        public Person(string inFirstName, string inLastName,
            int inYearBorn)
        {
            firstName = inFirstName;
            lastName = inLastName;
            if (inYearBorn > 0 && inYearBorn <= DateTime.Now.Year)
                yearBorn = inYearBorn;
            else
                yearBorn = DateTime.Now.Year;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - yearBorn;
            }
        }

        //Name property, inherited from IUniversalAge
        public string Name
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
    }
}
