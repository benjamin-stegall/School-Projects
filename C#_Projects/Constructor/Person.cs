using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
        public string FName { get; set; }
        public int Age { get; set; }

        // Constructor Chain

        public Person(string input1) : this(input1, 20)
        {
        }

        public Person(string input1, int input2)
        {
            FName = input1;
            Age = input2;
        }
    }
}
