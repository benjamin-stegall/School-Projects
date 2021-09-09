using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Gets item weight from user
            Console.WriteLine("Please enter the package weight.");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            // This checks if the item is too heavy
            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is too heavy!");
            }
            // If item isn't too heavy, user is prompted to enter dimensions
            else
            {
                Console.WriteLine("Please enter the package width.");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                // Calculating dimensions and storing in var packageDimension for later use
                decimal packageDimension = (packageWidth * packageHeight * packageLength);

                // This checks if item is too big
                if (packageDimension > 50)
                {
                    Console.WriteLine("Your package is too big!");
                }
                // If item isn't too big, the cost is calculated and displayed to user
                else
                {
                    decimal packageCost = (packageDimension * packageWeight) / 100;
                    Console.WriteLine("The packaging cost is $" + packageCost);
                }
            }
            // Ensures user can read result
            Console.ReadLine();
        }
    }
}
