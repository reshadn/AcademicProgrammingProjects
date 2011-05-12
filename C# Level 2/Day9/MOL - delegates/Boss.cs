using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOL
{
    class Boss
    {
        public int WorkCompleted()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Boss: Work Better!");
            return 6;
        }
    }
}
