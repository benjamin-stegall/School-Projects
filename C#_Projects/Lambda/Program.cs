using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining list
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FName = "Joe", LName = "Mamma" },
                new Employee { Id = 2, FName = "Zach", LName = "King" },
                new Employee { Id = 3, FName = "Gordon", LName = "Freeman" },
                new Employee { Id = 4, FName = "Harrison", LName = "Ford" },
                new Employee { Id = 5, FName = "Johnny", LName = "Quest" },
                new Employee { Id = 6, FName = "Joe", LName = "Kirk" },
                new Employee { Id = 7, FName = "Tommy", LName = "Jones" },
                new Employee { Id = 8, FName = "John", LName = "Wick" },
                new Employee { Id = 9, FName = "Barney", LName = "Calhoun" },
                new Employee { Id = 10, FName = "Randy", LName = "Random" }
            };

            List<Employee> employees1 = new List<Employee>();

            // This foreach finds anyone with the first name "Joe" and adds it to a new list
            foreach (var employee in employees)
            {
                if (employee.FName == "Joe")
                {
                    employees1.Add(employee);
                }
            }

            // This is a lambda alternative to the previous block
            List<Employee> employees2 = employees.Where(x => x.FName == "Joe").ToList();

            // This finds employees with an id over 5
            List<Employee> employees3 = employees.Where(x => x.Id > 5).ToList();

            // This displays the number of objects in the previous lists
            Console.WriteLine(employees1.Count());
            Console.WriteLine(employees2.Count());
            Console.WriteLine(employees3.Count());

            Console.ReadLine();
        }
    }
}
