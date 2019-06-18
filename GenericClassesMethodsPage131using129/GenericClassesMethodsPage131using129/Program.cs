using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassesMethodsPage131using129
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string>() { "Mae", "Gregg", "Angus", "Bea", "Germ" };
            foreach (string n in employeeString.Things)
            {
                Console.WriteLine(n);
            }

            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int>() { 22, 21, 23, 23, 19 };
            foreach (int m in employeeInt.Things)
            {
                Console.WriteLine(m);
            }


            Console.ReadLine();
        }
    }
}
