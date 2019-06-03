using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                double dimensions = packageWidth + packageHeight + packageLength;

                if (dimensions <= 50)
                {

                    double estimatedTotal = dimensions * packageWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + estimatedTotal);
                    Console.WriteLine("Thank you.");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            
            Console.ReadLine();
        }
    }
}
