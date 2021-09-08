using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1 income details
            Console.WriteLine("Person 1");
            Console.WriteLine("How many hours do you work?");
            string hoursWorkedInput1 = Console.ReadLine();
            // Converts user input to byte. Using decimal to make transferring data easier.
            decimal hoursWorked1 = Convert.ToDecimal(hoursWorkedInput1);
            Console.WriteLine("What is your hourly rate?");
            string hourlyRateInput1 = Console.ReadLine();
            // Converts user input to decimal
            decimal hourlyRate1 = Convert.ToDecimal(hourlyRateInput1);

            // Person 2 income details
            Console.WriteLine("Person 2");
            Console.WriteLine("How many hours do you work?");
            string hoursWorkedInput2 = Console.ReadLine();
            // Converts user input to byte
            decimal hoursWorked2 = Convert.ToDecimal(hoursWorkedInput2);
            Console.WriteLine("What is your hourly rate?");
            string hourlyRateInput2 = Console.ReadLine();
            // Converts user input to decimal
            decimal hourlyRate2 = Convert.ToDecimal(hourlyRateInput2);

            // Annual Salaries
            decimal annualSalary1 = (hourlyRate1 * hoursWorked1) * 261;
            decimal annualSalary2 = (hourlyRate2 * hoursWorked2) * 261;
            Console.WriteLine("Person 1 makes " + annualSalary1 + " a year.");
            Console.WriteLine("Person 2 makes " + annualSalary2 + " a year.");

            // Salary Comparison
            bool moneyComparison = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money?");
            Console.WriteLine(moneyComparison);
            Console.ReadLine();
        }
    }
}
