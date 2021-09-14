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
            // Create new object
            Math number = new Math();
            // Asks for input
            Console.WriteLine("Please enter a number");
            // Converts input to object value
            number.Number = Convert.ToInt32(Console.ReadLine());
            // Value is then used for these methods
            Compare1(number);
            Compare2(number);
            Compare3(number);
            Console.ReadLine();
        }
        
        
        // > Comparison
        public static Math Compare1(Math num)
        {
            if (num.Number + 2 > 10)
            {
                Console.WriteLine(num.Number + 2 + " is greater than 10");
            }
            else
            {
                Console.WriteLine(num.Number + 2 + " is not greater than 10");
            }
            
            return num;
        }

        // < Comparison
        public static Math Compare2(Math num)
        {
            if (num.Number + 10 < 25)
            {
                Console.WriteLine(num.Number + 10 + " is less than 25");
            }
            else
            {
                Console.WriteLine(num.Number + 10 + " is not less than 25");
            }

            return num;
        }

        // = Comparison
        public static Math Compare3(Math num)
        {
            if (num.Number + 4 == 12)
            {
                Console.WriteLine(num.Number + 12 + " is equal to 12");
            }
            else
            {
                Console.WriteLine(num.Number + 12 + " is not equal to 12");
            }

            return num;
        }
    }
}
