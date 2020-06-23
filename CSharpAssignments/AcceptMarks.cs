using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class AcceptMarks
    {
        public static int Total(List<int> markList)
        {
            int total = 0;
            foreach(int result in markList)
            {
                total = +result;
            }
            return total;
        }
        public static void Main()
        {
            Console.WriteLine("Enter 10 Marks");
            List<int> markList = new List<int>();
            for (int loopIndex = 0; loopIndex < 10; loopIndex++)
            {
                markList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Total is " + Total(markList));
            Console.WriteLine("Average is " + Total(markList) / 10);
            markList.Sort();
            Console.WriteLine(markList[0] + " is the Minimum Mark");
            Console.WriteLine(markList[markList.Count-1] + " is the Maximum Mark");
            Console.WriteLine("Mark in Ascending Order ");
            foreach (int result in markList)
            {
                Console.Write(result + " ");
            }
            markList.Reverse();
            Console.WriteLine("Mark in Descending Order ");
            foreach (int result in markList)
            {
                Console.Write(result+" ");
            }
            Console.ReadKey();
        }
    }
}
