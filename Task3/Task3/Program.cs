// See https://aka.ms/new-console-template for more information
using Fibonacci;

// Call class FibonacciByLoop
//FibonacciByLoop output = new FibonacciByLoop();
//long[] result = output.sequenceFibonacci(50);
//foreach(long i in result)
//{
//Console.WriteLine(i);
//}

// Call class FibonacciByRecursion
int j, n, ans;
Console.Write("Enter the length of series:");
n = int.Parse(Console.ReadLine());
FibonacciByRecursion fib = new FibonacciByRecursion(); // Creating Object 

for (int i  = 0; i < n; i++)
{
    ans = (int)fib.sequenceFibonacci(i);
    Console.Write(ans + "\t");
}


