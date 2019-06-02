using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI? (Enter true or false)");
            string previousDUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(previousDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(speedingTickets);

            bool qualified;
            if (age > 15 && dui == false && tickets < 4)
            {
                qualified = true;
            }
            else
            {
                qualified = false;
            }

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
