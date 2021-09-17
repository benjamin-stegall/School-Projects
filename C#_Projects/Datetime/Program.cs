using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays current time
            Console.WriteLine("Hello, today it is " + DateTime.Now);
            // Request user input
            Console.WriteLine("How many hours would you like to add to the current time?");
            // Converts user input
            int input = Convert.ToInt32(Console.ReadLine());
            // Takes current time and adds designated number of hours
            DateTime time = DateTime.Now.AddHours(input);
            // Modified time is displayed
            Console.WriteLine("The modified time is " + time);

            Console.ReadLine();
        }
    }
}
