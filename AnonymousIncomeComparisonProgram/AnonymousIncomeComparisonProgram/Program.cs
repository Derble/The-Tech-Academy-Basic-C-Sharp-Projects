using System;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRatePerson1 = Console.ReadLine();
            double hourlyRateOne = Convert.ToInt64(hourlyRatePerson1);
            Console.WriteLine("Hours worked per week?");
            string hoursPerWeekPerson1 = Console.ReadLine();
            double hoursPerWeekOne = Convert.ToInt64(hoursPerWeekPerson1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRatePerson2 = Console.ReadLine();
            double hourlyRateTwo = Convert.ToInt64(hourlyRatePerson2);
            Console.WriteLine("Hours worked per week?");
            string hoursPerWeekPerson2 = Console.ReadLine();
            double hoursPerWeekTwo = Convert.ToInt64(hoursPerWeekPerson2);

            double weeklySalaryPerson1 = hourlyRateOne * hoursPerWeekOne;
            double weeklySalaryPerson2 = hourlyRateTwo * hoursPerWeekTwo;

            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(weeklySalaryPerson1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(weeklySalaryPerson2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool oneComparedToTwo = weeklySalaryPerson1 > weeklySalaryPerson2;
            Console.WriteLine(oneComparedToTwo);
            Console.ReadLine();

        }
    }
}
