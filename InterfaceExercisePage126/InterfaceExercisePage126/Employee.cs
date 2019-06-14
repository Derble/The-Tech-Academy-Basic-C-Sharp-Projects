using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercisePage126
{
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
        //public override void SayName()
        //{
        //    base.SayName();
        //}
    }
}
