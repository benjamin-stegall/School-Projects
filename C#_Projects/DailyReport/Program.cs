using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("Welcome to The Tech Academy\nDaily Report");

            // Asks user's name and displays a greeting
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            // Asks for current course name
            Console.WriteLine("What course are you currently working on?");
            string currentCourse = Console.ReadLine();

            // Asks for page number
            Console.WriteLine("What page are you currently on?");
            string enteredNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(enteredNumber);

            // Asks if user needs help
            Console.WriteLine("Do you need any help? (Please type true or false)");
            string enteredHelp = Console.ReadLine();
            bool Help = Convert.ToBoolean(enteredHelp);

            // Asks user for any positive experiences
            Console.WriteLine("Did you have any positive experiences you would like to share?");
            string positiveFeedback = Console.ReadLine();

            // Asks for any additional feedback
            Console.WriteLine("Is there any other feedback you would like us to know?");
            string extraFeedback = Console.ReadLine();

            // Asks for hours studied
            Console.WriteLine("How many hours did you study today?");
            string enteredHours = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(enteredHours);

            // Thanks user
            Console.WriteLine("Thank you for your answers! An instructor will respond shortly.");
            // Console.ReadLine is here so that the user has time to read the response
            Console.ReadLine();
        }
    }
}
