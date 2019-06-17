using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorsPage129using120
{
    class Employee : Person
    {
        public int Id { get; set; }

        public void SayId()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " ID #: " + Id);
        }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator== (Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.Id == employee2.Id)
            {
                status = true;
            }
            return status;
        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            bool status = false;
            if (employee.Id != employee2.Id)
            {
                status = false;
            }
            return status;
        }
        
        
    }
}
