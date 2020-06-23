using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class DivisibleBy7
    {
        public static void Main()
        {
            int startNum = 200, endNumber = 300,div=7;
            Console.WriteLine("The Numbers Divisible By Seven Are :");
            for(int loopIndex = startNum; loopIndex <= endNumber; loopIndex++)
            {
                if(loopIndex%div==0)
                {
                    Console.WriteLine(loopIndex);
                }
            }
            Console.ReadKey();
        }
    }
}
