using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Fibonacci
    {
        public static void Main()
        {
            int endNumber = 40, fib = 0, count = 1;
            Console.WriteLine(fib + " ");
            Console.WriteLine(count + " ");
            for (int loopIndex = 0; fib < endNumber; loopIndex++)
            {
                fib += count;
                Console.WriteLine(fib + " ");
                count++;
            }


            Console.ReadKey();
        }
    }
}
