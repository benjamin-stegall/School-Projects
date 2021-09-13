using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // List
            List<int> numbers = new List<int>() { 2, 6, 12, 120 };
            
            try
            {
                // Instructional Message
                Console.WriteLine("What number would you like to divide by?");
                // Converts input to decimal
                decimal input = Convert.ToDecimal(Console.ReadLine());
                // Divides each number in the list by the input
                foreach (int num in numbers)
                {
                    // Using decimal for more accurate answers
                    decimal answer = num / input;
                    Console.WriteLine(num +" divided by " + input + " is " + answer);
                }
            }
            // Various catches to handle different inputs

            // Incorrect format will be the most likely error
            catch (FormatException ex)
            {
                Console.WriteLine("You can't divide that.");
            }
            // This prevents the user from destroying reality as we know it
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero.");
            }
            // This is here as a safety net
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Thanks for your input!");
            Console.ReadLine();
        }
    }
}
