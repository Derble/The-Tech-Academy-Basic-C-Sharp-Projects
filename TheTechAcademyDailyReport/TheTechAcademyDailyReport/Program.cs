using System;

//Derry Lammerding

namespace TheTechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHrs = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            //to make sure the values were stored
            //Console.WriteLine(courseName);
            //Console.WriteLine(pageNum);
            //Console.WriteLine(help);
            //Console.WriteLine(positiveExperiences);
            //Console.WriteLine(studyHrs);
            //Console.ReadLine();
        }
    }
}
