using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Example
{
    public class FactorialService
    {
        public int Calculate(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * Calculate(number - 1);
        }
    }
}
