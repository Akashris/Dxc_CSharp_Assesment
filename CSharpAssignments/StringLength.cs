using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class StringLength
    {
        public static void Main()
        {
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();
            Console.WriteLine("The Length of the String is " + str.Length);
            Console.ReadKey();
        }
    }
}
