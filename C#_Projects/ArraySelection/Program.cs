using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySelection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring arrays
            string[] stringArray = { "Freeman", "Wick", "Connor" };
            int[] numArray = { 2, 4, 6 };
            
            // Declaring List
            List<string> stringList = new List<string>();
            stringList.Add("Hi");
            stringList.Add("Bye");
            stringList.Add("See ya!");

            // Instructions
            Console.WriteLine("Please select an index (1, 2, 3)");

            bool stringSelected = false;
            int number = Convert.ToInt32(Console.ReadLine());

            // String Array
            do
            {
                // These display the different items based on user input
                switch (number)
                {
                    case 1:
                        Console.WriteLine(stringArray[0]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        stringSelected = true;
                        break;
                    case 2:
                        Console.WriteLine(stringArray[1]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        stringSelected = true;
                        break;
                    case 3:
                        Console.WriteLine(stringArray[2]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        stringSelected = true;
                        break;
                    // This runs if user enters an invalid value
                    default:
                        Console.WriteLine("Invalid Value");
                        Console.WriteLine("Please select an index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!stringSelected);

            bool numSelected = false;

            // Int Array
            do
            {
                // These display the different items based on user input
                switch (number)
                {
                    case 1:
                        Console.WriteLine(numArray[0]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        numSelected = true;
                        break;
                    case 2:
                        Console.WriteLine(numArray[1]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        numSelected = true;
                        break;
                    case 3:
                        Console.WriteLine(numArray[2]);
                        Console.WriteLine("Please select another index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        numSelected = true;
                        break;
                    // This runs if user enters an invalid value
                    default:
                        Console.WriteLine("Invalid Value");
                        Console.WriteLine("Please select an index (1, 2, 3)");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!numSelected);

            bool strListSelected = false;

            // String List
            do
            {
                // These display the different items based on user input
                switch (number)
                {
                    case 1:
                        Console.WriteLine(stringList[0]);
                        number = Convert.ToInt32(Console.ReadLine());
                        strListSelected = true;
                        break;
                    case 2:
                        Console.WriteLine(stringList[1]);
                        number = Convert.ToInt32(Console.ReadLine());
                        strListSelected = true;
                        break;
                    case 3:
                        Console.WriteLine(stringList[2]);
                        number = Convert.ToInt32(Console.ReadLine());
                        strListSelected = true;
                        break;
                    // This runs if user enters an invalid value
                    default:
                        Console.WriteLine("Invalid Value");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!strListSelected);

            Console.Read();
        }
    }
}
