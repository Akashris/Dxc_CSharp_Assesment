using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class DisplayNumbersBetween
    {
        public static void Main()
        {
            int number1, number2;
            Console.WriteLine("Enter the two numbers");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
       
            Console.WriteLine("The Numbers between them are :");
            for (int loopIndex = number1 ; loopIndex <=number2 ; loopIndex++)
            {
                Console.WriteLine(loopIndex);
            }
            Console.ReadLine();
        }

    }
}
