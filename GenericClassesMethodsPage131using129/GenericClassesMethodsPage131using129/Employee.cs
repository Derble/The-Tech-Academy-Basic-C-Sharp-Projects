using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassesMethodsPage131using129
{
    class Employee<T> : Person
    {
        public List<T> Things { get; set; }

        public int Id { get; set; }

        public void SayId()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " ID #: " + Id);
        }
        

    }
}
