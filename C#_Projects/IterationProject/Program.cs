using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            // Array
            string[] names = { "jesse", "gordon", "john" };
            // Request user input
            Console.WriteLine("What would you like to add to the names in the array?");
            // Storing input as variable
            string strInput = Console.ReadLine();
            // Array iteration
            for (int i = 0; i < names.Length; i++)
            {
                // This adds user input to each string in the array and then displays the new strings
                names[i] = (names[i] + strInput);
                Console.WriteLine(names[i]);
            }

            
            

            // Part 2
            Console.WriteLine("Please enter the password:");
            // Storing input as variable
            string password = Console.ReadLine();
            // Originally used 'while', causing inf loops
            if (password == "please")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Get Out, Loser!");
            }




            // Part 3
            int number = 1;
            int number2 = 5;
            int number3 = 1;
            int number4 = 5;
            // Adds to "number" while it is less than "number2"
            while (number < number2)
            {
                number++;
            }
            // Adds to "number3" while less or equal to "number4"
            while (number3 <= number4)
            {
                number3++;
            }
            Console.WriteLine(number);
            Console.WriteLine(number3);




            // Part 4
            // Requesting Input
            Console.WriteLine("What are you looking for?");
            // Storing input as variable and converting to lowercase to avoid issues
            string listSearch = Console.ReadLine().ToLower();
            // List
            List<string> names1 = new List<string>() { "jesse", "gordon", "john",};
            for (int i = 0; i < names1.Count; i++)
            {
                // Displays matching item or displays an error if nothing is found
                if (listSearch == names1[i])
                {
                    Console.WriteLine("That item was found on idex" + i);
                    break;
                }
                else if (!names1.Contains(listSearch))
                {
                    Console.WriteLine("Sorry! We couldn't find that item");
                    break;
                }
            }




            // Part 5
            // Requesting Input
            Console.WriteLine("What are you looking for?");
            // Storing input as variable and converting to lowercase to avoid issues
            string listSearch1 = Console.ReadLine().ToLower();
            // List
            List<string> names2 = new List<string>() { "jesse", "gordon", "john", "gordon" };
            // Displays results based on input
            Console.WriteLine("Results:");
            // Finds requested data and displays their index
            for (int i = 0; i < names2.Count; i++)
            {
                if (listSearch1 == names2[i])
                {
                    Console.WriteLine(i);
                }
                // If no matching data is found, this is displayed
                else if (!names2.Contains(listSearch1))
                {
                    Console.WriteLine("No matching data");
                    break;
                }
            }




            // Part 6
            // List
            List<string> names3 = new List<string>() { "jesse", "gordon", "john", "gordon" };
            // This list contains distinct strings
            List<string> distinctNames = new List<string>();
            foreach (string name in names3)
            {
                // If the distinct list doesn't contain the string, add it to the distinct list and display this
                if (!distinctNames.Contains(name))
                {
                    distinctNames.Add(name);
                    Console.WriteLine(name + " is distinct");
                }
                // If the string has already been added, display this
                else if (distinctNames.Contains(name))
                {
                    Console.WriteLine(name + " is a duplicate");
                }
            }


            Console.ReadLine();
        }
    }
}
