using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci

{
    public class FibonacciByLoop
    {
        public long[] sequenceFibonacci(long number)
        {
            long[] sequence = new long[number];
            sequence[0] = 0;
            sequence[1] = 1;
            for (long i = 2; i < number; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }
            return sequence;          

        }
       
    }
}
