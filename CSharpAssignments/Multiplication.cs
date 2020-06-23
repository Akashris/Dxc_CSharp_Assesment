using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Multiplication
    {
        public static void Main()
        {
            Console.WriteLine("Enter The Number For Multiplication Table");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int loopIndex = 1; loopIndex <= 20; loopIndex++)
            {
                Console.WriteLine(number + " x " + loopIndex + " = " + number * loopIndex);
            }
            Console.ReadKey();
        }
    }
}
