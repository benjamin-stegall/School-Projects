using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Request Input
            Console.WriteLine("Enter a day of the week.");
            string input = Console.ReadLine().ToLower();

            // This attempts to parse the data passed in by the user
            try
            {
                var day = (WeekDays)Enum.Parse(typeof(WeekDays), input);
                Console.WriteLine(day);
                Console.ReadLine();
            }
            // If it fails, it displays an error message
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day");
                Console.ReadLine();
            }
        }
            
        // If user doesn't enter one of these, it causes an error    
        public enum WeekDays
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
    }
}
