using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloads
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance
            Math math = new Math();
            // Asks for input
            Console.WriteLine("Enter a number");
            // Stores input
            int input = Convert.ToInt32(Console.ReadLine());
            // Display result
            Console.WriteLine(math.Add(input));

            // New instance
            Math math1 = new Math();
            // Asks for input
            Console.WriteLine("Enter a decimal");
            // Stores input
            decimal input1 = Convert.ToDecimal(Console.ReadLine());
            // Display result
            Console.WriteLine(math1.Add(input1));

            // New instance
            Math math2 = new Math();
            // Asks for input
            Console.WriteLine("Enter a number");
            // Stores input
            string input2 = Console.ReadLine();
            // Display result
            Console.WriteLine(math2.Add(input2));

            Console.ReadLine();
        }
    }
}
