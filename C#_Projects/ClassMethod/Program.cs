using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance
            Math math = new Math();

            // Get input and divide by 2
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + " divided by 2 is");
            math.Divide(input);

            // Get second input and divide by first input
            Console.WriteLine("Enter another number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input2 + " divided by " + input + " is");
            math.Divide(input, input2);

            // Calling an output method from static class
            Math2.Add(out int output);
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
