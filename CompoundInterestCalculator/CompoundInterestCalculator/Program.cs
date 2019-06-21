using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Compound Interest Calculator. Please enter the following information:\n");
            Console.WriteLine("Please enter in your starting amount (principal):");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in your annual interest rate as a decimal: (Example: 7% = 0.07)");
            decimal r = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many times is it compunded per year? Enter 12 if it is compounded monthly or 1 if it is compounded yearly.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How may years will it be compounded for?");
            int t = Convert.ToInt32(Console.ReadLine());

            double rDouble = (double)r;

            double power = Math.Pow(( 1 + (rDouble / n)),(n* t));
            double a = p * power;

            Console.WriteLine("The total value will be {0} after {1} year(s).", a, t);

            //Console.WriteLine(p);
            //Console.WriteLine(r);
            //Console.WriteLine(n);
            //Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
