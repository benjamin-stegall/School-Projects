using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // New object
            Employee employee = new Employee();
            employee.FName = "Sample";
            employee.LName = "Student";

            // Asks for input
            Console.WriteLine("Please do some work");
            // Saving input
            string input = Console.ReadLine();
            // Calling interface here
            employee.Quit(input);

            Console.ReadLine();

            
        }
    }
}
