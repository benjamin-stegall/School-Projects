using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Math
    {
        public void Divide(int input)
        {
            Console.WriteLine(input / 2);
            return;
        }

        // Overloaded Method
        public void Divide(int input, int input2)
        {
            Console.WriteLine(input / input2);
            return;
        }
    }
}
