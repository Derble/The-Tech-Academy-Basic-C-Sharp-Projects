using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \\Hello\", Jesse.\n Hello a new line. \n \t Hello on a tab.";
            ////string fileName = "C:\\Users\\Jesse";//shows the backslash using the escape character \
            //string fileName = @"C:\Users\Jesse";//@ tells comp that everything in the quotes is to be printed, no escape sequences

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            ////name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.WriteLine(length);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();//dynamic object that can be exapnded/contracted without expensive memory overhead from creating new strings with string class

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
