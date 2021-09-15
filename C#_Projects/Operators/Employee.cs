using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int ID { get; set; }

        // Overloading ==
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
                return true;
            else
                return false;
        }

        // Overloading !=
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
                return true;
            else
                return false;
        }

        // This allows us to compare the properties as opposed to whole object
        // By default, c# will return false as seperate objects are different
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // Also required to avoid errors
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
