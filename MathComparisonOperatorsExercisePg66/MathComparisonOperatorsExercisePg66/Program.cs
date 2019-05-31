using System;

//Derry Lammerding

namespace MathComparisonOperatorsExercisePg66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number that you would like to multiply by 50:");
            string multiplyByFifty = Console.ReadLine();
            long multByFifty = Convert.ToInt64(multiplyByFifty);
            long product = multByFifty * 50;
            Console.WriteLine(multByFifty+ " * 50 is " + product);
            Console.ReadLine();

            Console.WriteLine("Please enter a number that you would like to add 25 to:");
            string addTwentyFive = Console.ReadLine();
            double addTwentyFiveInt = Convert.ToInt64(addTwentyFive);
            double sum = addTwentyFiveInt + 25;
            Console.WriteLine(addTwentyFiveInt + " + 25 is " + sum);
            Console.ReadLine();

            Console.WriteLine("Please enter a number that you would like to divide by 12.5:");
            string divideBy = Console.ReadLine();
            double divideByDecimal = Convert.ToInt64(divideBy);
            double quotient = divideByDecimal / 12.5;
            Console.WriteLine(divideByDecimal + " divided by 12.5 is " + quotient);
            Console.ReadLine();

            Console.WriteLine("Please enter a number to see if it is greater than 50:");
            string checkGreaterThanFifty = Console.ReadLine();
            double checkFifty = Convert.ToInt64(checkGreaterThanFifty);
            bool check = checkFifty > 50;
            Console.WriteLine(check);
            Console.ReadLine();

            Console.WriteLine("Please enter a number to find the remainder when divided by 7:");
            string remainderDividedBySeven = Console.ReadLine();
            double remainderDivSeven = Convert.ToInt64(remainderDividedBySeven);
            double resultModulus = remainderDivSeven % 7;
            Console.WriteLine(remainderDivSeven + " divided by 7 has a remainder of " + resultModulus);
            Console.ReadLine();
            
        }
    }
}
