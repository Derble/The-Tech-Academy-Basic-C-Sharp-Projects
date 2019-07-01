using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception //creating our own exception that inherits from Exception
    {
        public FraudException() //standard constructor
            : base() { } //inherits from base or the base instructor
        public FraudException(string message)//overloading the constructor method
            : base(message) { }
    }
}
