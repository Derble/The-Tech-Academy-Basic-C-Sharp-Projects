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
    }
}
