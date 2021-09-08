using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("Nostate Car Insurance");

            // Applicant Questions
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (Please type true or false)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int Ticket = Convert.ToInt32(Console.ReadLine());

            // Applicant Qualification
            bool oldEnough = Age >= 15;
            bool noDUI = DUI == false;
            bool noTicket = Ticket <= 3;

            bool Qualify = oldEnough && noDUI && noTicket;
            Console.WriteLine("Qualified? " + Qualify);
            Console.ReadLine();
        }
    }
}
