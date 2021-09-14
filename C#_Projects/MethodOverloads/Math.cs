using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloads
{
    class Math
    {
        public int Add(int input)
        {
            return input + 2;
        }

        public int Add(decimal input)
        {
            // Converts input to int
            return Convert.ToInt32(input) - 2;
        }

        public int Add(string input)
        {
            // Converts input to an int
            return Convert.ToInt32(input) * 2;
        }
    }
}
