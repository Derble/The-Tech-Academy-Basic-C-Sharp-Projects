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
            try
            {
                Console.WriteLine("Hello, please enter an integer:");
                int numOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You may enter a second number if you'd like to:");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                
                OptionalParameter n = new OptionalParameter();

                int mathIsDone = n.someMoreMath(numOne, numTwo);
                Console.WriteLine(mathIsDone);
            }
            catch (FormatException ex)
            {
                int numTwo = 12;

            }
            catch (Exception ex)
            {
                int numTwo = 12;
            }
            

            
            Console.ReadLine();
        }
    }
}
