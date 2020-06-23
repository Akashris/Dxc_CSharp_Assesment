using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class Series
    {
        public static void Main()
        {
            int incrementNumber = 1;
            for(int loopIndex = 0; loopIndex <= 625; )
            {
                Console.WriteLine(loopIndex);
                loopIndex += incrementNumber;
                incrementNumber += 2;
            }
            Console.ReadKey();
        }
    }
}
