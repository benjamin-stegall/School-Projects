using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for input
            Console.WriteLine("Enter a number");
            // Converts input to an int
            int input = Convert.ToInt32(Console.ReadLine());

            // Calls math methods and passes in user input
            Console.WriteLine(input + " + 2 = " + Math.Add(input));
            Console.WriteLine(input + " - 2 = " + Math.Subtract(input));
            Console.WriteLine(input + " * 2 = " + Math.Multiply(input));
            Console.ReadLine();
        }

    }
}
