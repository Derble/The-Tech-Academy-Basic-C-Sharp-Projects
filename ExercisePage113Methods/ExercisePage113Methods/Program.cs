using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePage113Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 7;
            int d = 5;
            MathOperation i = new MathOperation();
            i.OperationAndDisplay(7, 5);//passing in the two numbers directly
            i.OperationAndDisplay(c, d);//specifying parameters by name
            Console.ReadLine();
        }
        
    }
}
