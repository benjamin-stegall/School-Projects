using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FName + LName);
            return;
        }
    }
}
