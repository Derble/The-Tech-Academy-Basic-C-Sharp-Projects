using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsExercisePage111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to work with?");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Operations n = new Operations();

            int two = n.multipliedByTwo(userInput);
            int six = n.addSix(two);
            int result = n.totalAfterDivideByTwo(six);

            Console.WriteLine(userInput + " multiplied by two, added with six, then divided by two equals " + result);
            Console.ReadLine();

            //For testing
            //Console.WriteLine(two);
            //Console.WriteLine(six);
            //Console.WriteLine(result);

            //first code to make sure operations work
            //public Operations(userInput)
            //{
            //    int multipliedByTwo = userInput * 2;
            //    int addSix = multipliedByTwo + 6;
            //    int totalAfterDivideByTwo = addSix / 2;
            //    return totalAfterDivideByTwo;
            //}

        }



    }
}
