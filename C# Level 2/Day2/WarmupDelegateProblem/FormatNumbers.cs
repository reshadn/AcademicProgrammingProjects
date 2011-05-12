using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarmupDelegateProblem
{
    class FormatNumbers
    {
        public delegate string FormatSingle(float number);

        public static string returnDollars(float number)
        {
            return string.Format("{0:C}", number);
        }

        public static string returnPercentage(float number)
        {
            return string.Format("{0:P}", number);
        }
    }
}
