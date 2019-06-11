using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodExercisePage144
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading n = new MethodOverloading();

            int numOne = 8;
            int firstMethodAnswer = n.someMath(numOne);
            Console.WriteLine(firstMethodAnswer);

            MethodOverloading m = new MethodOverloading();

            double numTwo = 12.56;
            int secondMethodAnswer = m.someMath(numTwo);
            Console.WriteLine(secondMethodAnswer);

            MethodOverloading x = new MethodOverloading();

            string numThree = "9";
            int thirdMethodAnswer = x.someMath(numThree);
            Console.WriteLine(thirdMethodAnswer);


            //This code also works but does not instantiate the class at each step like the directions asked.
            /*
            MethodOverloading n = new MethodOverloading();

            int numOne = 8;
            int firstMethodAnswer = n.someMath(numOne);
            Console.WriteLine(firstMethodAnswer);

            double numTwo = 12.56;
            int secondMethodAnswer = n.someMath(numTwo);
            Console.WriteLine(secondMethodAnswer);

            string numThree = "9";
            int thirdMethodAnswer = n.someMath(numThree);
            Console.WriteLine(thirdMethodAnswer);
            */


            Console.ReadLine();
        }
    }
}
