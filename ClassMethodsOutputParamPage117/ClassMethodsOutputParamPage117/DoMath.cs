using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsOutputParamPage117
{
    class DoMath
    {
        public void DivideByTwo(int a, out int b)
        {
            b = a / 2;

        }
        
        /*//No longer needed
        public void DivideByTwo(double a, out double b)
        {
            b = a / 2;

        }
        */

        public void DivideByTwo(decimal a, out decimal b)
        {
            b = a / 2;

        }

        public static class Greeting
        {
            public static string GetGreeting()
            {
                return "Please enter an integer:";
            }
        }
    }
}
