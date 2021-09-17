using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using const to store welcome message
            const string welcome = "Welcome to the Clone Machine";
            Console.WriteLine(welcome);

            // Storing input as a var
            var input1 = "John Doe";

            // Display new object
            Person person = new Person(input1);
            Console.WriteLine(person.FName + " is " + person.Age + " years old.");
            Console.ReadLine();
        }
    }
}
