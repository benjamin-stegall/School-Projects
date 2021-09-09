using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction message
            Console.WriteLine("You awake to find yourself in some kind of chamber with four tunnels branching in different directions.\nChoose a direction (North, South, East, West)");
            // Using .ToLower() to avoid any capitalization issues
            string direction = Console.ReadLine().ToLower();

            bool isCorrect1 = false;

            // First Chamber
            while (!isCorrect1)
                switch (direction)
                {
                    // This case runs if user types "north"
                    case "north":
                        // Response to user's input
                        Console.WriteLine("You walk down the northern tunnel only to find a wall blocking your path. You are forced to turn back.\nChoose a direction (North, South, East, West)");
                        direction = Console.ReadLine().ToLower();
                        break;
                    // This case runs if user types "south"
                    case "south":
                        // Response to user's input
                        Console.WriteLine("You walk down the southern tunnel only to find a locked, reinforced door blocking your path. You are forced to turn back.\nChoose a direction (North, South, East, West)");
                        direction = Console.ReadLine().ToLower();
                        break;
                    // This case runs if user types "east"
                    case "east":
                        // Response to user's input
                        Console.WriteLine("You walk down the eastern tunnel for some time only to find it too dark to continue. You are forced to turn back.\nChoose a direction (North, South, East, West)");
                        direction = Console.ReadLine().ToLower();
                        break;
                    // This case runs if user types "west"
                    case "west":
                        // Response to user's input
                        Console.WriteLine("You walk down the western tunnel. After some walking you come into another chamber...");
                        // This ends the loop
                        isCorrect1 = true;
                        break;
                    // This case runs if user types an invalid direction
                    default:
                        // Response to user's input
                        Console.WriteLine("That isn't a valid direction.\nChoose a direction (North, South, East, West)");
                        direction = Console.ReadLine().ToLower();
                        break;
                }

            // Second Chamber
            Console.WriteLine("This chamber looks almost identical to the one you started in.\nThe only difference you notice is the lack of a western tunnel.\nChoose a direction (North, South, East)");

            string direction2 = Console.ReadLine().ToLower();
            bool isCorrect2 = false;

            do
            {
                switch (direction2)
                {
                    // This case runs if user types "north"
                    case "north":
                        // Response to user's input
                        Console.WriteLine("You walk down the northern tunnel only to find a large, reinforced gate blocking your path. You are forced to turn back.\nChoose a direction (North, South, East)");
                        direction2 = Console.ReadLine().ToLower();
                        break;
                    // This case runs if user types "east"
                    case "east":
                        // Response to user's input
                        Console.WriteLine("You just came from there. Why are you trying to go back?\nChoose a direction (North, South, East)");
                        direction2 = Console.ReadLine().ToLower();
                        break;
                    // This case runs if user types "south"
                    case "south":
                        // Response to user's input
                        Console.WriteLine("You walk down the southern tunnel. After some walking you come into a chamber many times larger than the previous ones, with a large, circular pool in the center.\nYou see people in robes surrounding the pool.\nBefore you can do anything, everything fades to black...");
                        // This ends the loop
                        isCorrect2 = true;
                        break;
                    // This case runs if user types an invalid direction
                    default:
                        // Response to user's input
                        Console.WriteLine("That isn't a valid direction.\nChoose a direction (North, South, East)");
                        direction2 = Console.ReadLine().ToLower();
                        break;
                }
            }
            while (!isCorrect2);
            // Ensures user can read response
            Console.Read();


        }
    }
}
