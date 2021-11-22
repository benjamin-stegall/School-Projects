using System;
using System.Collections.Generic;

namespace RandomQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfQuotes = new List<string>()
            {
                "“Whenever you find yourself on the side of the majority, it is time to reform (or pause and reflect).” -Mark Twain",
                "“The only true wisdom is in knowing you know nothing.” -Socrates",
                "“Any fool can know. The point is to understand.” -Albert Einstein",
                "“All knowledge hurts.” -Cassandra Clare"
            };

            Random rnd = new Random();

            int r = rnd.Next(listOfQuotes.Count);

            Console.WriteLine(listOfQuotes[r]);
            Console.ReadLine();
        }
    }
}
