using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new object
            Employee employee = new Employee();
            employee.FName = "Sample";
            employee.LName = "Student";

            // Calling method that displays object name
            employee.SayName();
            Console.ReadLine();
        }
    }
}
