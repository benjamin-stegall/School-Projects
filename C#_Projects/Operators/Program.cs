using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // New objects
            Employee employee1 = new Employee();
            employee1.ID = 2;
            Employee employee2 = new Employee();
            employee2.ID = 1;

            // Checks if id is equal
            if (employee1 == employee2)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are not equal");
            }

            Console.ReadLine();
        }
    }
}
