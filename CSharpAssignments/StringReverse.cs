using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class StringReverse
    {
        public static void Main()
        {
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();
            char[] stringArray = str.ToCharArray();
            string reverseString = String.Empty;
            for (int loopIndex = stringArray.Length - 1; loopIndex >=0; loopIndex--)
            {
                reverseString += stringArray[loopIndex];
            }
            Console.WriteLine("The Reverse Of The String Is " + reverseString);
            Console.ReadKey();
        }
    }
}
