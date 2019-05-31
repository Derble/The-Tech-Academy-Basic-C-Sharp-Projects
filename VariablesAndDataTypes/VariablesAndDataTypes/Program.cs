using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myName = "derble";
            //int myNumber = 5;

            /*
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();//readline takes in
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            */

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();//readline can only take in a string so we have to convert, casting
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;

            byte hoursWorked = 42;

            sbyte currentTemperature = -23;

            char randomLetter = 'X';

            char questionMark = '\u2103';

            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            decimal moneyInBank = 100.5m;//financial transactions

            double heightInCentimeters = 211.302020292;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "derble";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();


        }
    }
}
