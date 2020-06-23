using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Factorial
    {
        public static void Main()
        {
            int number, value = 1;
            Console.WriteLine("Enter The Number");
            number = Convert.ToInt32(Console.ReadLine());
            for(int loopIndex = number; loopIndex > 0; loopIndex--)
            {
                value *= loopIndex;
            }
            Console.WriteLine("factorial is " + value);
            Console.ReadKey();
        }
    }
}
