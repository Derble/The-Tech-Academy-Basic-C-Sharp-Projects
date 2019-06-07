using System;
using System.Collections.Generic;


namespace ExceptionHandlingExercisePage_106
{
    class Program
    {
        static void Main(string[] args)
        {
            bool useableValue = false;
            try
            {
                List<int> numbers = new List<int>() { 100, 50, 40, 20, 10, 2, 18, 42 };
                Console.WriteLine("What number would you like to divide by?");
                int divisor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    int quotient = numbers[i] / divisor;
                    Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + quotient);
                }
                useableValue = true;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
                useableValue = false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                useableValue = false;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                useableValue = false;
            }
            finally
            {
                Console.ReadLine();
            }

            if (useableValue == true)
            {
                Console.WriteLine("You entered a useable value. Thank you!");
            }

            Console.ReadLine();
        }
    }
}
