using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    class StringPalindrome
    {
        public static void Main()
        {
            int flag = 0;
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();
            char[] stringArray = str.ToCharArray();
            for (int loopIndex = 0; loopIndex <= stringArray.Length/2; loopIndex++)
            {
                if (stringArray[loopIndex] == stringArray[stringArray.Length-1 - loopIndex])
                {
                    continue;
                }
                else
                {
                    flag = 1;
                }
            }
            if(flag==0)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome");

            }

            Console.ReadKey();
        }
    }
}
