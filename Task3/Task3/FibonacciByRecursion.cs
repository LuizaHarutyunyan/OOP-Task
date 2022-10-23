using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciByRecursion
    {
        public long sequenceFibonacci(long number)
        {
            
            if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                 return sequenceFibonacci(number-1)+sequenceFibonacci(number-2);
            }

        }

      

    }


}
