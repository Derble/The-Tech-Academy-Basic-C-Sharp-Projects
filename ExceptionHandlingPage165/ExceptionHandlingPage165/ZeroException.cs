using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPage165
{
    public class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
       // public ZeroException(string message)
        //    : base(message) { }
    }
}
