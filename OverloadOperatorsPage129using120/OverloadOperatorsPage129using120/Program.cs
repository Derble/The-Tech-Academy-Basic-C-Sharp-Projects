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

            Console.ReadLine();
        }
        
    }
}
