﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPage165
{
    public class NegativeException : Exception
    {
        public NegativeException()
            : base() { }
        //public NegativeException(string message)
        //    : base(message) { }
    }
}
