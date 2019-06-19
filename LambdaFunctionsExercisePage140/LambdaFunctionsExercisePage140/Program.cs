using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctionsExercisePage140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Aldsman", Id = 1 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Bernard", Id = 2 });
            employees.Add(new Employee { FirstName = "Ned", LastName = "Stark", Id = 3 });
            employees.Add(new Employee { FirstName = "Jon", LastName = "Snow", Id = 4 });
            employees.Add(new Employee { FirstName = "Hodor", LastName = "Hodor", Id = 5 });
            employees.Add(new Employee { FirstName = "Sirius", LastName = "Black", Id = 6 });
            employees.Add(new Employee { FirstName = "Albus", LastName = "Dumbledore", Id = 7 });
            employees.Add(new Employee { FirstName = "Hermione", LastName = "Granger", Id = 8 });
            employees.Add(new Employee { FirstName = "Harry", LastName = "Potter", Id = 9 });
            employees.Add(new Employee { FirstName = "Ron", LastName = "Weasley", Id = 10 });

            /*check to make sure employees were being stored correctly
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + " " + e.Id);
            }
            */

            //List of all employees with first name Joe using foreach
            List<Employee> newList = new List<Employee>();
            foreach (Employee i in employees)
            {
                if (i.FirstName == "Joe")
                {
                    newList.Add(new Employee { FirstName = i.FirstName, LastName = i.LastName, Id = i.Id});
                }
            }
            foreach (Employee w in newList)
            {
                Console.WriteLine(w.FirstName + " " + w.LastName + " " + w.Id);
            }
            Console.ReadLine();

            //List of all employees with first name Joe using lambda expressions
            List<Employee> newEmployeeList = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee y in newEmployeeList)
            {
                Console.WriteLine(y.FirstName + " " + y.LastName + " " + y.Id);
            }
            Console.ReadLine();

            //List of all employees with an Id number greater than 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee e in idGreaterThanFive)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + " " + e.Id);
            }

            Console.ReadLine();
        }
    }
}
