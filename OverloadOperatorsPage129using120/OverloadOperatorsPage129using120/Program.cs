using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorsPage129using120
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 444 };
            Employee employee2 = new Employee() { FirstName = "Sebajun", LastName = "Nujabes", Id = 555 };
            Employee employee3 = new Employee() { FirstName = "Yanya", LastName = "Caballista", Id = 444 };
            
            employee.SayId();
            employee2.SayId();
            employee3.SayId();

            if (employee == employee2)
            {
                Console.WriteLine("Employees 1 and 2 have the same Id!");
            }
            else
            {
                Console.WriteLine("Employees 1 and 2 do not have the same Id!");
            }

            if (employee == employee3)
            {
                Console.WriteLine("Employees 1 and 3 have the same Id!");
            }
            else
            {
                Console.WriteLine("Employees 1 and 3 do not have the same Id!");
            }

            Console.ReadLine();
        }
        
    }
}
