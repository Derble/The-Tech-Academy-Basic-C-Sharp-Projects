using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsOutputParamPage117
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter an integer:");
            Console.WriteLine(DoMath.Greeting.GetGreeting());
            int numOne = Convert.ToInt32(Console.ReadLine());
            int result;
            DoMath n = new DoMath();
            n.DivideByTwo(numOne, out result);
            Console.WriteLine(result);

            /*//Created before decimal using double because of some conversion errors. Figured it out.
            Console.WriteLine("Please enter a decimal:");
            double numTwo = Convert.ToDouble(Console.ReadLine());
            double result2;
            n.DivideByTwo(numTwo, out result2);
            Console.WriteLine(result2);
            Console.ReadLine();
            */

            Console.WriteLine("Please enter a decimal:");
            decimal numThree = Convert.ToDecimal(Console.ReadLine());
            decimal result3;
            n.DivideByTwo(numThree, out result3);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
