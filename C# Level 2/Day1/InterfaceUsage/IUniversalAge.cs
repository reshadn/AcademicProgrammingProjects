using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceUsage
{
    //Creating Interface; cannot instantiate; can be a variable 
    public interface IUniversalAge //use naming convention IAge, IExample
    {
        //Read-only property 
        int Age { get; }

        //Read-only property 
        string Name { get; }
    }
}
