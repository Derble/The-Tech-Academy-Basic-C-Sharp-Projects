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
            //Still working on this
           
            
            Console.WriteLine("Hello, please enter an integer:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to enter another integer? Type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
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
                
                  
            Console.ReadLine();
        }
    }
}
