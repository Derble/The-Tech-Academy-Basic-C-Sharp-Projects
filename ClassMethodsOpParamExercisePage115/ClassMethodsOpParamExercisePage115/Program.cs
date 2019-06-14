using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsOpParamExercisePage115
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, please enter an integer:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer if you would like to.");
            string answer = Console.ReadLine();
            int numTwo;
            int result;
            OptionalParameter n = new OptionalParameter();
            if (string.IsNullOrEmpty(answer))
            {

                result = n.someMoreMath(numOne);

            }
            else
            {
                numTwo = Convert.ToInt32(answer);
                result = n.someMoreMath(numOne, numTwo);
            }
            
            Console.WriteLine("Your product is " + result);
            

            //Code that was removed after I got help and fixed other code.
            /*
            if (answer == "yes")
            {
                Console.WriteLine("Please enter in a second integer:");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                OptionalParameter n = new OptionalParameter();

                int result = n.someMoreMath(numOne, numTwo);
                Console.WriteLine(numOne + " times " + numTwo + " equals " + result);
            }
            else
            {
                OptionalParameter x = new OptionalParameter();

                int result = x.someMoreMath(numOne);
                Console.WriteLine(numOne + " times 12 equals " + result);
            }
               */


            Console.ReadLine();
        }
    }
}
