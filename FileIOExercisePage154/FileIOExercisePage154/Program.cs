using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOExercisePage154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string writeText = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Derry\Desktop\number_entered.txt", writeText);
            string readText = File.ReadAllText(@"C:\Users\Derry\Desktop\number_entered.txt");
            Console.WriteLine("The number from the text file is: {0}", readText);
            Console.ReadLine();
        }
    }
}
