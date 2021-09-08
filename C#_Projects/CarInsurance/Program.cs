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
            string ageInput = Console.ReadLine();
            int Age = Convert.ToInt32(ageInput);

            Console.WriteLine("Have you ever had a DUI? If so, how many?");
            string duiInput = Console.ReadLine();
            int DUI = Convert.ToInt32(duiInput);

            Console.WriteLine("Have you had any speeding tickets? If so, how many?");
            string ticketInput = Console.ReadLine();
            int Ticket = Convert.ToInt32(ticketInput);

            // Applicant Qualification
            bool oldEnough = Age >= 15;
            bool noDUI = DUI == 0;
            bool noTicket = Ticket <= 3;

            bool Qualify = oldEnough && noDUI && noTicket;
            Console.WriteLine("Qualified? " + Qualify);
            Console.ReadLine();
        }
    }
}
