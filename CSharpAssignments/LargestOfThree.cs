using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class LargestOfThree
    {
        public static void Main()
        {
            Console.WriteLine("Enter Three numbers");
            List<int> numberList = new List<int>();
            for(int loopIndex = 0; loopIndex < 3; loopIndex++)
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            numberList.Sort();
            Console.WriteLine(numberList[numberList.Count-1] + " is the largest number");
            Console.ReadKey();
        }
    }
}
