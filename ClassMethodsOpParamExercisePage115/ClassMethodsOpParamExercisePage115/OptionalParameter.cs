using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsOpParamExercisePage115
{
    class OptionalParameter
    {
        /*//not needed
        public int someMoreMath(int a)
        {
            
            int c = a * 12;
            return c;
            
        }
        */
        
        public int someMoreMath(int a, int b = 10)
        {
            int c = a * b;
            return c;
            
        }
        

        //public void someMoreMath(int a, int b = 10)
        //{
        //    int c = a * b;
        //}


        /* // used in a previous version, kept for later revision
        public void someMoreMath(int a, params object[] b)
        {
            //int result;
            if (b != null)
            {
                foreach (int i in b)
                {
                    a = a * i;
                }
            }
            Console.WriteLine(a);

        }*/
    }  
}
