using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMultInput
{
    class Math
    {
        // If input2 recieves no value, set to default of 0
        public static int Add(int input, int input2=0)
        {
            return (input + input2) * 5;
        }
    }
}
