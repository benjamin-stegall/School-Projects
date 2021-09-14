using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FName + LName);
            return;
        }
    }
}
