using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercisePage156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be: " + DateTime.Now.AddHours(hours) + " in " + hours + " hour(s).");
            Console.ReadLine();
        }
    }
}
