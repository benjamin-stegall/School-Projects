using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultInput2
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
            int num1 = Convert.ToInt32(Console.ReadLine());
            // Asks for input
            Console.WriteLine("Enter another number");
            // Stores input
            int num2 = Convert.ToInt32(Console.ReadLine());
            // Passes input
            math.Add(input: num1, input2: num2);
            
            Console.ReadLine();
        }
    }
}
