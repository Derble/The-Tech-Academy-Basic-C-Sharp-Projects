using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExercisePage144
{
    class MethodOverloading
    {
        public int someMath(int a)
        {
            int addFive = a + 5;
            return addFive;
        }

        public int someMath(decimal b)
        {
            int multiplyFive = Convert.ToInt32(b * 5);
            return multiplyFive;
        }

        public int someMath(string c)
        {
            int subtractFive = Convert.ToInt32(c) - 5;
            return subtractFive;
        }

    }
}
