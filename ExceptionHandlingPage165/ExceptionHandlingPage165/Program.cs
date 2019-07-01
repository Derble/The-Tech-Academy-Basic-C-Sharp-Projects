using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPage165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new NegativeException();
                }
                if (age == 0)
                {
                    throw new ZeroException();
                }

                int currentYear = 2019;
                int yearBorn = currentYear - age;
                Console.WriteLine("You were born in: {0}", yearBorn);
                Console.ReadLine();
            }
            catch (ZeroException)
            {
                Console.WriteLine("Please enter a non-zero number.");
                Console.ReadLine();
            }
            catch (NegativeException)
            {
                Console.WriteLine("Please enter a non-negative number.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your system administrator");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
