using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsExercisePage97
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome to Twin Peaks. ";
            string name = "My name is Margaret Lanterman. ";
            string twinPeaks = "I live in Twin Peaks. ";

            string pilot = welcome + name + twinPeaks;
            Console.WriteLine(pilot);

            string logLady = "I am known as the log lady. ";
            logLady = logLady.ToUpper();
            Console.WriteLine(logLady);

            StringBuilder agentCooper = new StringBuilder();

            agentCooper.Append("Diane, 7:30 am, February twenty-fourth. ");
            agentCooper.Append("Entering town of Twin Peaks. ");
            agentCooper.Append("Five miles south of the Canadian border, twelve miles west of the state line. ");
            agentCooper.Append("Never seen so many trees in my life. ");
            agentCooper.Append("As W.C. Fields would say, I'd rather be here than Philadelphia. ");
            agentCooper.Append("It's fifty-four degrees on a slightly overcast day. ");
            agentCooper.Append("Weatherman said rain.");
            agentCooper.Append("If you could get paid that kind of money for being wrong sixty percent of the time it'd beat working. ");
            agentCooper.Append("Mileage is 79,345, gauge is on reserve, I'm riding on fumes here, I've got to tank up when I get into town. ");
            agentCooper.Append("Remind me to tell you how much that is. ");
            agentCooper.Append("Lunch was $6.31 at the Lamplighter Inn. ");
            agentCooper.Append("That's on Highway Two near Lewis Fork. ");
            agentCooper.Append("That was a tuna fish sandwich on whole wheat, a slice of cherry pie and a cup of coffee. ");
            agentCooper.Append("Damn good food. ");
            agentCooper.Append("Diane, if you ever get up this way, that cherry pie is worth a stop. ");

            Console.WriteLine(agentCooper);

            Console.ReadLine();

          
        }
    }
}
