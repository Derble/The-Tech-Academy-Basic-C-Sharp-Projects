using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatementCountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //press enter to count down
            int x = 10;
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
                Console.ReadLine();
            }
            if (x == 0)
            {
                Console.WriteLine("Blast off!!!");
            }
            Console.ReadLine();
        }
    }
}
