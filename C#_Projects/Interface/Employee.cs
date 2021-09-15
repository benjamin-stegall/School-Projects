using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee : Person, IQuittable
    {
        public void Quit(string input)
        {
            Console.WriteLine("Not good enough, You're Fired.");
            return;
        }
    }
}
