using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileStatementCountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while
            //press enter to count down
            int x = 10;
            do
            {
                Console.WriteLine(x);
                Console.ReadLine();
                x--;
                if (x == 0)
                {
                    Console.WriteLine("Blast off!!!");
                }
            }
            while (x > 0);
            Console.ReadLine();
            
        }
    }
}
