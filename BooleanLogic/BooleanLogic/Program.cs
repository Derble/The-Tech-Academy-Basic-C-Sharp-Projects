using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false);//AND
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);//OR
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine(true == true);//EQUAL
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            Console.WriteLine(true != true);//NOT EQUAL
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            Console.WriteLine(true ^ true);//XOR will evaluate to true but only if one not both are true
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.WriteLine(true && true && true && false);
            Console.WriteLine(true && true && true || false);

            Console.ReadLine();
        }
    }
}
