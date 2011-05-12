using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceUsage
{
    public class OakTree : IUniversalAge
    {
        private int rings;

        //constructor with 1 parameter
        public OakTree(int yearPlanted)
        {
            rings = DateTime.Now.Year - yearPlanted;
        }

        //method to add an additional ring
        public void AddRing()
        {
            rings++;
        }

        public int Age
        {
            get
            {
                return rings / 3;
            }
        }

        //Name property, inherited from IUniversalAge
        public string Name
        {
            get
            {
                return "An Oak Tree";
            }
        }
    }
}
