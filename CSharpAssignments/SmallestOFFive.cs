
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class SmallestOfFive
    {
        public static void Main()
        {
            Console.WriteLine("Enter Five numbers");
            List<int> numberList = new List<int>();
            for (int loopIndex = 0; loopIndex < 5; loopIndex++)
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            numberList.Sort();
            Console.WriteLine(numberList[0] + " is the Smallest number");
            Console.ReadKey();
        }
    }
}
