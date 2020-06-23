using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Cubes
    {
        public static void Main()
        {
            Console.WriteLine("Enter An Integer Number ");
            int value = 5;
            long sum = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < value )
            {
                int temp = number;
                number = value;
                value = temp;

            }
            for(int loopIndex = value; loopIndex <= number; loopIndex++)
            {
                sum += loopIndex * loopIndex * loopIndex;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
