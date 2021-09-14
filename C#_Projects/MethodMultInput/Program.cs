using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks for input
            Console.WriteLine("Enter a number (Required)");
            // Converts input to an int
            int input = Convert.ToInt32(Console.ReadLine());
            
            // Asks for input
            Console.WriteLine("Enter another number (Optional)");
            string inputStr = Console.ReadLine();
            // This checks if the entered value is empty or null
            if (!String.IsNullOrEmpty(inputStr))
            {
                int input2 = Convert.ToInt32(inputStr);
                Console.WriteLine(Math.Add(input, input2));
            }
            // If it is empty/null, only pass the first input
            else
            {
                Console.WriteLine(Math.Add(input));
            }
           
            Console.ReadLine();
        }
    }
}
