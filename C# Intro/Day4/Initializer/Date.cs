using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Initializer
{
    class Date
    {
        private int mYear, mMonth, mDay;

        //public Date()
        //{
        //    mYear = 2001;
        //    mMonth = 1;
        //    mDay = 1;
        //}

        // Improved code with Initializer
        public Date()
            : this(1970, 1, 1)
        {
        }

        public Date(int year, int month, int day)
        {
            mYear = year;
            mMonth = month;
            mDay = day;
        }

        public override string ToString()
        {
            return "Year= " + mYear.ToString() + "\n" +
                "Month= " + mMonth.ToString() + "\n" +
                "Day= " + mDay.ToString() + "\n";
        }
    }
}
