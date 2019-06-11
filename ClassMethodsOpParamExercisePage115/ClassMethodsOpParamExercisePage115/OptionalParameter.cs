using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsOpParamExercisePage115
{
    class OptionalParameter
    {
        public int someMoreMath(int a, int b = 12)
        {
            int c = a * b;
            return c;
        }
    }
}
