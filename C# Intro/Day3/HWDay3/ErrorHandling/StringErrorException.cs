using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorHandling
{
        public class StringErrorException : ApplicationException
        {
            public StringErrorException()       // constructor --> has same name as class
                : base("Illegal string data")
            {
            }
            public StringErrorException(string message)     // overloaded method --> same method name as previous, different parameters 
                : base(message)
            {
            }
            public StringErrorException(string message, Exception inner) :
                base(message, inner)
            {
            }
        }
}
