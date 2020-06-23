using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class OddEven
    {
        public static void Main()
        {
            int number1;
            Console.WriteLine("Enter the two numbers");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 2 == 0)
            {
                Console.WriteLine(number1 + " is An Even Number");
            }
            else
            {
                Console.WriteLine(number1 + " is An Odd Number");
            }
            Console.ReadKey();
        }
    }
}
